#include<iostream>
using namespace std;
class stock
{
    private:
    string symbol;
    string name;
    
    public:
    float previous_price;
    float current_price;
    stock()
    {
        cout<<"symbol:";
        cin>>symbol;
        cout<<"name:";
        cin>>name;
        cout<<"previous price:";
        cin>>previous_price;
        cout<<"current price:";
        cin>>current_price;

    }
    void get(string symbol);
    void get(string name);
    void setting(float p_price);
    float getting(void);
    void setting(float c_price);
    float getting(void);
    void get_change_percent();
};
void stock::get(string name)
{
    cout<<"business :"<<name;
}
void stock::get(string symbol)
{
    cout<<" Company :"<<symbol;
}
void stock::setting(float p_price)
{
    previous_price=p_price;

}
float stock::getting(void)
{
    return previous_price;
}
void stock::setting(float c_price)
{
    current_price=c_price;
}
float stock::getting(void)
{
    return current_price;
}
void get_change_percent()
{
    cout<<"change previous price to current price:\n";

}

int main()
{
    stock st;
    float previous_price;
    float current_price;
    st.setting(20.5);
    cout<<"previous pice:"<<st.getting()<<endl;
    st.setting(20.35);
    cout<<"current price:"<<st.getting()<<endl;
    st.get_change_percent();
    {
        cout<<previous_price<<endl;
        cout<<current_price<<endl;

    }

    

}