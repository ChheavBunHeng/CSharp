#include<iostream>
#include<fstream>
using namespace std;

int main()
{
    fstream outin;
    char ch;
    outin.open("myfile.txt",ios::out);
    while((ch=cin.get()) != '$')
    {
        outin.put(ch);
        outin.close();
    }
    outin.open("myfile.txt",ios::out);
    while(!outin.eof())
    {
        ch=outin.get();
        cout<<ch;
    }
    outin.close();



}
