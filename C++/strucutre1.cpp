#include <iostream>
#include<string>
using namespace std;

struct Company{
    string name;
    int age;
    int id;
};

int main(){
    Company com[3] = {{"heng",1,1},{"heng",2,2},{"heng",3,3}};
    int age;
    int id;
    
    int option = 1;
    switch(option)
    {
        case 1:
        //A
            cout<<"Input age:";
            cin>>age;
            for(int i = 0; i <=2 ;i++)
            {
                if(age == com[i].age)
                {
                cout<<com[i].age<<"\t"<<com[i].id<<"\t"<<com[i].name<<endl;
                }
            }
            break;
        case 2:

        
    }
    
    //B
    for(int i = 0; i <=2 ;i++)
    {
        if((com[i].age % 2) == 0)
        {
        cout<<com[i].age<<"\t"<<com[i].id<<"\t"<<com[i].name<<endl;
        }
    }
    //C
    cout<<"Input id:";
    cin>>id;
    for(int i = 0; i <=2 ;i++)
    {
        if(id == com[i].id)
        {
        cout<<com[i].age<<"\t"<<com[i].id<<"\t"<<com[i].name<<endl;
        }
    }
    
}