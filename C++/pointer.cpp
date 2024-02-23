#include<iostream>

using namespace std;

int main()

{
    int num1,num2,result1,result2,result3,result4,result5;

    cout<<"Input num1:";
    cin>> num1;

    cout<<"Input num2:";
    cin >> num2;
    result1 = num1 + num2;
    result2 = num1 - num2;
    result3 = num1 * num2;
    result4 = num1 / num2;
    result5 = (result1 + result2 + result3 + result4)/4;
    cout<<result1<<endl;
    cout<<result5<<endl;
}
