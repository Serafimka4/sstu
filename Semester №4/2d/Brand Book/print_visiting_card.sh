#!/usr/bin/env bash

readonly SVG_DIR='Sources/Visiting\ Card'
eval cd $SVG_DIR

readonly BUILD_DIR='../../Build'
mkdir -p $BUILD_DIR

for i in *.svg; do
	out=$(echo ${i/svg/pdf})

	echo "Converting \"$out\"..."
	inkscape "$i" --export-filename="$out" 2> /dev/null
done

echo 'Merging PDFs...'
pdfunite 'Visiting Card (Front).pdf' 'Visiting Card (Back).pdf' "$BUILD_DIR/Visiting Card.pdf"

echo 'Deleting temorary files...'
rm -f *.pdf

echo 'Done'
