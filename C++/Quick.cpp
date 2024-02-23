#include<iostream>
using namespace std;
typedef
int partition(int array[],int low,int high)
{
    int i,j,key;
    key = array[low];
    i = low + 1;
    j = high;
    while (1)
    {
        while(i < high && key>= array[i])
        {
            i++;
        }
        while(key <array[j])
        {
            j--;
        }
        if(i < j)
        {
            swap(array[i],array[j]);
        }
        else
        {
            swap(array[low],array[j]);
        }
    }
    
}
void quicksort(int array[],int low,int high)
{
    int j;
    if(low < high)
    {
        j = partition(array,low,high);
        quicksort(array,low,j-1);
    }
}
int main()
{
    int i,n,a[20];
    printf("Input limiter");
    scanf("%d",&n);
    for(i = 1;i<=n;i++)
    {
        printf("Input values of number:");
        scanf("%d",&a[i]);
    }
    quicksort(a,0,n-1);
    for(i = 1;i<=n;i++)
    {
        printf("%d",a[i]);
    }   
}