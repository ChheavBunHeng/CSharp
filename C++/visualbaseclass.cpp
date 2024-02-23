#include<iostream>
using namespace std;

class A
{
    public:
            void say()
            {
                cout<<"Hello world"<<endl;
            }
};

int main()
{

class B:public virtual A{};

class C:public virtual A{};
class D:public B,public C{};

}
int main()
{
    D obj;
    obj.say();
at_quick_exitzq
}