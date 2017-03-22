#Python program to append dateTaken metat data to .jpg file name
#Test photo dateTaken: 11/27/2011
#Test photo name: photo.jpg

import exifread

#Open image file for reading (binary mode)
path_name = "C:\Users\Clayton\Documents\GitHub\MAPP-Construction\DateTaken-JobPhotos\photo.JPG"
f = open(path_name, 'rb')

#Return Exif tags
tags = exifread.process_file(f)
print(tags.keys())
for tag in tags.keys():
	if tag not in ('JPEGThumbnail', 'TIFFThumbnail', 'Filename', 'EXIF MakerNote'):
		print("Key: %s, value %s" % (tag, tags[tag]))