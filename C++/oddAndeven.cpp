#include<iostream>
#include<stdlib.h>
using namespace std;

int main()
{
    int *p, n,even,odd;
    cout<<"Input N";
    cin >> n;
    p = (int*)malloc(n*sizeof(int));
    for(int i = 0; i < n;i++)
    {
        cin >> p[i];
    }
    cout<<"Even:";
    for(int i = 0; i < n;i++)
    {
        
        if((p[i]%2) == 0)
        {
            cout<<p[i];
        }
        
    }
    for(int i = 0; i < n;i++)
    {
        if((p[i]%3) == 0)
        {
            cout<<" Odd: "<<p[i];
        }
    }   
    free(p);
}