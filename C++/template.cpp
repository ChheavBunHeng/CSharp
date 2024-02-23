#include<iostream>
using namespace std;

template<class min>
void min1(min num1,min num2)
{
    min small;
    small = num1;
    if(small < num2)
    {
        small = num2;
    }
    cout <<small;
}

int main()
{
    
    min1(1,2);
    min1('a','b');

}
