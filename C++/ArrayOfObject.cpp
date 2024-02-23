// handling
#include <fstream>
#include <iostream>
#include<string.h>
using namespace std;

class Student
{
    private:
    int id;
    char name[20];
    float av;
    public:
    Student(int i = 0,char *n = "", float a = 0.0):
    id(i),av(a)
    {
        strcpy(name,n);
    }
    void input();
    void output();
};
void Student::input()
{
    cout<<"Input ID";
    cin >> id;
    cout<<"Input Name:";
    cin.get(name,20);
    cout<<"Input av";
    cin >> av;
    
}
void Student::output()
{
    cout<<id<<endl;
    cout<<name<<endl;
    cout<<av<<endl;
}
int main()
{
    Student stu[20];
    for(int i = 1; i <= 5;i++)
    {
        stu[i].input();
    }
    ofstream out("stu.bin",ios::binary);
    out.write((char * )&stu,5*sizeof(Student));
    out.close();
    ifstream fin("stu.bin",ios::binary|ios::ate):
    for(int i = 0+)
}