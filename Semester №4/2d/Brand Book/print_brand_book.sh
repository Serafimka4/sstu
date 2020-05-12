#!/usr/bin/env bash

readonly SRC_DIR='Sources/Brand\ Book'
eval cd $SRC_DIR

readonly BUILD_DIR='../../Build'
mkdir -p $BUILD_DIR

for i in *.svg; do
	out=$(echo ${i/svg/pdf})

	echo "Converting \"$out\"..."
	inkscape "$i" --export-filename="$out" 2> /dev/null
done

echo 'Merging PDFs...'
pdfunite *.pdf "$BUILD_DIR/Brand Book.pdf"

echo 'Deleting temorary files...'
rm -f *.pdf

echo 'Done'
