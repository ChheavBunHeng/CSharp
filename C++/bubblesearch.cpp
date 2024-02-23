#include<iostream>

using namespace std;

class student
{
    private:
    int num1,num2;
    int result;
    public:
    void input();
    void output();

};
int main()
{
    
    student std;
    std.input();
    std.output();
}
void student::input()
{
    student std;
    cout<<"Input";
    cin>>std.num1;
}
void student::output()
{
    student std;
    cout<<std.num1;
}