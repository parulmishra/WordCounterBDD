# _Word Counter_

#### _Word Counter 08.11.17_

#### By _**Parul Mishra Dubedy**_

## Description

_This Mvc application takes a word and a string and returns a count based on occurences for the word in the entered sentence._

| Behavior  | Input  | Output  |
|---|---|---|
|1.  When the user enters a word and a sentence with single occurence of word in it and clicks a button `Generate Count` , their count is generated. | > word entered: and <br> >sentence entered: I Like Pizza and Icecream <br> | 1
|2.  When the user enters a word and a sentence with multiple occurence of word in it clicks a button `Generate Count` , their count is generated. | > word entered: and <br> > sentence entered: I like Pizza and IceCream and Yoghurt. <br> | 2 
|3.  When the user enters a word and a sentence with no occurence of word in it clicks a button `Generate Count` , their count is generated. | > word entered: and <br> > sentence entered: I like Pizza, IceCream, Yoghurt. <br> | 0
|4.  When the user does not enters a word and but enters a string and clicks a button `Generate Count` , an Error Message is generated. | > word entered:  <br> > sentence entered: I like Pizza and IceCream and Yoghurt. <br> | Error Message: Please Enter a Word.
|5.  When the user enters a word and but does not enters a string and clicks a button `Generate Count` , an Error Message is generated. | > word entered: and <br> > sentence entered:  <br> | Error Message: Please Enter a Sentence.
|6.  When the user does not enters a word and a string and clicks a button `Generate Count` , an Error Message is generated. | > word entered:  <br> > sentence entered:  <br> | Error Message: Please Enter a Word and a Sentence.


## Setup/Installation Requirements

* _Clone this repository_

## Known Bugs

* _No known bugs at this time_

## Technologies Used

_HTML_
_CSS_
_BootStrap_
_MVC_
_C#_
_MSTest_
### License

This software is licensed by the MIT License

Copyright (c) 2017 **Parul Mishra Dubedy**
