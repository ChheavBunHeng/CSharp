#include <iostream>

using namespace std;

int main()
{
    string Name;
    string Password;
    // char Name[20];
    // char Password[20];
    cout<<"Input Name:";
    cin>>Name;
    if(Name=="admin")
    {
        cout<<"Input Password:";
        cin>>Password;
        if(Password=="123456")
        {
            cout<<"Welcome";
        }
        else
        {
            cout<<"Wrong Password";
        }
    }
    else
    {
        cout<<"Sorry there no such user"; 
    }
}