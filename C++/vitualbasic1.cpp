#include<iostream>
using namespace std;
class person
{
    public:
    int id;
};
class dob:public virtual person
{
    public:
    string day,moth,year;
};
class point:public virtual person
{
    public:
    int math,english,khmer;
};
class student:public dob,public point
{
    public:
    void input();
    void output();
};
void student::input()
{
    cout <<"Input student ID";
    cin >> id;
    cout <<"Input Student Date of Birth";
    cin >> day;
    cin >> moth;
    cin >> year;
    cout <<"Input student score";
    cin >> math;
    cin >> khmer;
    cin >> english;
}
void student::output()
{
    cout <<id<<endl;
    cout <<day<<"\t"<<moth<<"\t"<<year<<endl;
    cout <<math<<"\t"<<english<<"\t"<<khmer<<endl;

}
int main()
{       
    student student[10];
    for(int loop = 1;loop <= 2;loop++)
    {
        student[loop].input();

    }
    for(int loop = 1;loop <= 2;loop++)
    {

        student[loop].output();
    }
}
