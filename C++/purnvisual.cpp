#include<iostream>
#include<stdlib.h>

using namespace std;

class base
{
    private:
    int x;
    int y;
    public:
    virtual void inputdata() = 0;
    virtual void display() = 0;

};
class derived1 : public base
{
    private:
    int id;
    char name[20];
    public:
    void inputdata();
    void display();
};
class derived2 : public base
{
    private: 
    float heigh;
    float weigth;
    public:
    void inputdata();
    void display();

};
void derived1::inputdata()
{
    cout <<"Enter id of a student = ";
    cin >> id;
    cout <<"Enter name of student";
    cin>>name;
}
void derived1::display()
{
    cout<<id<<"\t"<<name<<endl;
    
}
void derived2::inputdata()
{
    cout <<"Input student heigh";
    cin >> heigh;
    cout <<"Input student weight";
    cin >> weigth;
       
}
void derived2::display()
{
    cout <<heigh<<"\t"<<weigth<<endl;
}
int main()
{
    base *ptr[3];
    derived1 obj1;
    derived2 obj2;
    ptr[0] = &obj1;
    ptr[1] = &obj2;
    ptr[0]->inputdata();
    ptr[1]->inputdata();

    ptr[0]->display();
    ptr[1]->display(


.


    );

}
// int main()
// {
//     base *ptr[10];
//     derived1 obj1[10];
//     derived2 obj2[10];
//     int n;
//     cout <<"Input n";
//     cin >> n;
//     for(int i = 1; i <= n;i++)
//     {
//         ptr[0] = &obj1[i];
//         ptr[1] = &obj2[i];
//         for(int j = 1;j<=2;j++)
//         {
//             ptr[j]->inputdata();
//         }
//     }
//     for(int i = 1; i <= n;i++)
//     {
//         ptr[0] = &obj1[i];
//         ptr[1] = &obj2[i];
//         for(int j = 1;j<2;j++)
//         {
//             ptr[j]->display();
//         }
//     }
// }