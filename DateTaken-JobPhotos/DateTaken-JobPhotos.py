#Python program to append dateTaken metat data to .jpg file name
#Test photo dateTaken: 11/27/2011
#Test photo name: photo.jpg

import exifread
import os
import shutil

#Open image file for reading (binary mode)
photo_name = "photo.JPG"
f = open(photo_name, 'rb')

#Return Exif tags
tags = exifread.process_file(f)
#Statments below for testing
#print(tags.keys())
# for tag in tags.keys():
# 	if tag not in ('JPEGThumbnail', 'TIFFThumbnail', 'Filename', 'EXIF MakerNote'):
# 		print("Key: %s, value %s" % (tag, tags['Image DateTime']))
#print('Date Taken: ' + str(tags['EXIF DateTimeDigitized']))

dateTaken = str(tags['EXIF DateTimeDigitized'])
print('Date Taken: ' + dateTaken)

def copy_rename(old_file_name, new_file_name):
	src_dir = os.curdir
	dst_dir = os.path.join(os.curdir, "renamed")
	src_file = os.path.join(src_dir, old_file_name)
	shutil.copy(src_file, dst_dir)
	dst_file = os.path.join(dst_dir, old_file_name)
	new_dst_file_name = os.path.join(dst_dir, new_file_name)
	os.rename(dst_file, new_dst_file_name)

copy_rename(photo_name, str(dateTaken)+str(photo_name))