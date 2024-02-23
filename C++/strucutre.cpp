//Dynamic array of function;

#include<iostream>
using namespace std;
int *array;
string **name;
int loop,limit;

int main()
{
    cout<<"Input limiter:";
    cin>>limit;
    name = new string(20)
    array = new int(limit);
    for(loop= 1;loop <=limit;loop++)
    {
        cout<<"Input Num";
        cin >> array[loop];
    }
    for(loop= 1;loop <=limit;loop++)
    {
        cout<<"Num :"<<array[loop]<<endl;
    }
}