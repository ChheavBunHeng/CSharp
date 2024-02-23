#include<iostream>
#include<string.h>
#include<fstream>
using namespace std;

class Student
{
    private:
    int id;
    char name[20];
    float av;
    public:
    Student(int i = 0, char *n = " ",float a = 0.0):
    id(i),av(a)
    {
        strcpy(name,n);
    }
    void input();
    void output();
    static void heading();

};

void Student::input()
{
    cout<<"Input ID:";
    cin >> id;
    cout<<"Input name:";
    cin.get(name,20);
    cout<<"Input av:";
    cin>>av;
}
void Student::output()
{
    cout<<id<<endl;
    cout<<name<<endl;
    cout<<av<<endl;
}


int main()
{
    //update or overwrrite;
    Student stu(4,"",90.00);
    Student st;
    fstream finout("kaka.bin"
    ,ios::binary|ios::in|ios::ate);
    finout.seekp((0)*sizeof(Student),ios::beg);
    // st.input();
    finout.write((char*)&stu,sizeof(Student));
    finout.close();


    
}   
