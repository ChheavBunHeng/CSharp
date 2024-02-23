#include<iostream>
#include<fstream>
using namespace std;
class person
{
    protected:
    string name;
    short age;
    public:
    void getData()
    {
        cout<<"Enter name:";cin >> name;
        cout<<"Enter age:";cin >> age;
    }
    void show()
    {
        cout<<name<<"\t"<<age<<endl;
    }
};
int main()
{
    person pers;
    pers.getData();
    ofstream outfile("PERSON.DAT",ios::binary);
    outfile.write((char*)(&pers),sizeof(pers));
    outfile.close();

    ifstream infile("PERSON.DAT",ios::binary);
    infile.read((char*)(&pers),sizeof(pers));
    pers.show();
    return 0;

}