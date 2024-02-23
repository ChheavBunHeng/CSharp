#include<iostream>
#include<fstream>

using namespace std;
int main()
{
    char ch;
    ifstream in;
    ofstream out;
    in.open("/home/duck/Visual/C/TextText.txt");
    while(!in.eof())
    {
        ch = in.get();
        cout<<ch;
    }
    in.close();
}