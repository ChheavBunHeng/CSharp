    #include <iostream>
    using namespace std;

    int main()
    {
        int player;
        bool is_open[456] = { false };
        int Alive = 0,Death = 0;
        cout <<"Input the player:";
        cin >> player;
        for (int  i = 0;  i < player; ++ i)
        {
            for (int  j =  i;  j < player;  j +=  i+1)
            {
            is_open[ j] = !is_open[ j];
            }
        }

        for (int  i = 0;  i < player; ++i){
        if(is_open[i])
        {
            cout <<i<<" is open"<<endl;
            Alive = Alive + 1;

        }
        else
        {
            cout <<i<<" is close"<<endl;
            Death = Death + 1;
        }
        }
        cout <<"Alive:"<<Alive<<endl;
        cout <<"Death:"<<Death<<endl;
        return 0;
    }