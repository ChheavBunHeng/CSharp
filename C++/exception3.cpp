#include<iostream>
using namespace std;

int main()
{
    int StudentAge;
    try
    {
        cout<<"StudentAge"<<endl;
        cin >> StudentAge;
        if(StudentAge <= 0)
        {
            throw "Input Error";
        }
        cout<<StudentAge<<endl;
    }
    catch(const string* MessageError)
    {
        cout<<"Error:"<<MessageError;
    }
}
