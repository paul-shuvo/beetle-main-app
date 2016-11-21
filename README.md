Beetle application
----------------------

Project Beetle is an initiative from Team Leprechaun. It is one of the 14 projects out of around 200+ which has already been selected for the Round 2 of Microsoft Imagine Cup 2012 (Software Design).

[image]

Beetle is an application, running on a mobile phone (Windows Phone), which can identify crop diseases based on a picture of a leaf.
It has been developed for paddy crops in Bangladesh, but, as long as proper agronomical guidance is provided to the developers, they could add cocoa, and possibly coffee diseases as well (as long as these diseases can be identified by visible transformations on the crops/plants/leaves).

It uses windows phone sdk and microsoft azure services to leverage the image detection algorithms in the server. It uses image synthesize library and Neural Network to train itself and detect crop diseases from taken pictures.

It captures video feedback from the camera, uses the sdk to take reference images. then it uses sobel operator to substract edge.

[image]

It also uses histogram tool to match locally stored values to adjust the image brightness and color saturation.

[image]

It then sends the data via ajax call. The azure server receives the request and the image, run the image synthesizer and main Neural Network and return the result.

[image]

It uses additional two libraries that resides in the server. Please refer to image synthesizer and beetle NN for more information



Installation
------------
You need to install visual studio and windows phone sdk to run this software. The other libraries can be run on any os ( if it can install python and other python related packages ).