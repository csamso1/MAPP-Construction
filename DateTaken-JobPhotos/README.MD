# Program Goals
1. Program takes in a working directory, and searches the directory for .jpg files

2. For every .jpg file the system extracts the 'EXIF DateTimeDigitized' metadata.

3. System uses this metadata to create a new name for this file, by appending this returned metadata to the beginning of the file name followed by a underscore and the orgnial name.
	Example: photo.jpeg -> 3-22-2017_photo.jpg

4. In order to maintain access to the orginal photos, the system will place a copy of the photo with the modified name in a new folder named 'Photos With Dates' 

5. System preforms this operation on every .jpg file in the provided directory.

6. System (probablly recursivly) preforms this same process on every subdirectory of the provided directory, while maintaining the orgninal folder structure in the new 'Photos With Dates' folder.

# Example folder structure

## Orginal folder structure

	UserProvidedFolder

		SubFolder_0

			photo_2.jpg

		SubFolder_1

			photo_3.jpg

		photo_0.jpg

		photo_1.jpg


## Resulting folder structure after program execution

	UserProvidedFolder

		SubFolder_0

			photo_2.jpg

		SubFolder_1

			photo_3.jpg

		photo_0.jpg

		photo_1.jpg

		**NewFolder_Renamed**

			-SubFolder_0

				-DateTaken_photo_2.jpg

			-SubFolder_1

				-DateTaken_photo_3.jpg

			DateTaken_photo_0.jpg

			DateTaken_photo_1.jpg
