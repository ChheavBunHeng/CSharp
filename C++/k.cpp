//C++ Program to count words in a sentence
#include <iostream>
#include <cstring>
using namespace std;
  
int main() {
   char string[100], *token;
   int count = 0;
     
   cout << "Enter a string\n";
   cin.getline(string, 100);
     
   token = strtok(string, " ");
     
   while(NULL != token) 
   {
       count++;
       token = strtok(NULL, " ");
   }
     
   cout << "Word Count : "<<count;
   return 0;
}