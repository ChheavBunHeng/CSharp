#include<iostream>
using namespace std;

int main()
{
    cout <<"Start\n";
    try
    {
        cout <<"Inside try block.\n";
        throw 99;
        cout <<"This will not execute";
        throw 199;
    }
    catch (int i)
    {
        cout <<"Caught an exception -- value is:" ;
        cout <<i<<endl;
    }
    cout <<"End";
}
