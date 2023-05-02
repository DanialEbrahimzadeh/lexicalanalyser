# lexicalanalyser
a lexical analyser: the first stage of designing a compiler

key words: int double void if else while return
operators: + - * / := < <= == != >= > ( ) { } [ ] , ;
ID: [a-zA-Z_][a-zA-Z0-9_]
numbers: [0-9][0-9]*[.[0-9]*]?
comments: between /* and */

input: a .txt file
output: SymTable.txt

State machine (using Flex):
![image](https://user-images.githubusercontent.com/52605366/235704443-dec28f49-cf52-404d-a2cf-e226cfb99c00.png)
