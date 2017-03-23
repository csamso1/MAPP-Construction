import os
from PIL import Image
import exifread

#Important note, if I call os.chdir("whatev") then this affects all operations globally, regardless of recusion layer... Should explain why I made it the way I did

#So one little bug that I haven't been able to track down yet. If you run this twice with Dated_Photos already made then it still works perfectly fine
# except that inside Dated_Photos there's another sub folder called Dated_Photos containing only another folder called Dated_Photos containing only another folder
#called Dated_Photos containing only another folder called Dated_Photos containing only another folder called Dated_Photos containing only another folder ... You get the point


def directoryCrawler(*args):
    #Checks the number of arguments provided. In python there isn't overloading, but an ambiguous amount of args is allowed -- which is what I'm doing
    if len(args) == 0:
        print('STARTING')
        path = os.getcwd()
        if not os.path.exists(path + '/Dated_Photos'):
            os.makedirs(path + '/Dated_Photos')
        datePath = path + '/Dated_Photos'
    else:
        path = args[0]
        datePath = args[1]
    print(os.listdir(path))
    files = os.listdir(path)
    print('-' * 60)
    #Creates a list of all items in current directory, if an item is a directory then in hops in it and recursively calls itself
    #else If an item is of type jpg or jpeg then it calls exifExecutor on it
    #Otherwise nothing happens
    for f in files:
        if os.path.isdir(path + '/' + f) == True and (((path + '/' + f).__contains__('Dated_Photos')) == False):
            print(f)
            #Creates a corresponding folder in the new dated directory for each dir we go through, unless the dir already exist
            if not os.path.exists(datePath + '/'+f):
                os.makedirs(datePath + '/'+f)
            directoryCrawler(path + '/'+f,datePath + '/'+f)

        elif f.lower().endswith(('.jpg', '.jpeg')):
            exifExecutor(path, f, datePath)
        else:
            pass    #Not needed, just weird personal preference to include else: pass.


def exifExecutor(path, name, datePath):
    path_name = path + '/' + name

    f = open(path_name, 'rb')
    tags = exifread.process_file(f)
    if 'EXIF DateTimeOriginal' or 'EXIF DateTimeDigitized' or 'Image DateTime' or 'GPS GPSDate' in tags:
        dateString = ''
        if 'EXIF DateTimeOriginal' in tags:
            dateString = tags['EXIF DateTimeOriginal'].printable
        elif 'EXIF DateTimeDigitized' in tags:
            dateString = tags['EXIF DateTimeDigitized'].printable
        elif 'Image DateTime' in tags:
            dateString = tags['Image DateTime'].printable
        elif 'GPS GPSDate' in tags:
            dateString = tags['GPS GPSDate'].printable
        print('---'*50,'\nTHE DATE STRING IS: ',dateString)
        dateSplit = dateString.split(' ')
        dateOnly = dateSplit[0]
        dateArray = dateOnly.split(':')
        #Some jpgs have an exif but no data associated with it requiring this if stmnt
        if len(dateArray) > 2:
            formattedDate = dateArray[1] + '-' + dateArray[2] + '-' + dateArray[0]
            img = Image.open(path_name)
            img.save(datePath + '/' + formattedDate + '_' + name)
        else:
            img = Image.open(path_name)
            img.save(datePath + '/NO_DATE_' + name)
    else:
        img = Image.open(path_name)
        img.save(datePath + '/NO_DATE_' + name)

def main():
    #Run this file in a directory that contains a folder that you want as the root of you're search
    #Otherwise, uncomment and add the path to photos (untested method but I don't see why I wouldn't work)
    #os.chdir('path / to / root / dir / of / photos ')
    directoryCrawler()

if __name__  == '__main__': main()
