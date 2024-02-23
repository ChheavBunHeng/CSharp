#include<iostream>
using namespace std;
int BinarySearch(int Array[],int limiter,int target);
int main()
{
    int index;
    int Array[] = {4,7,9,11,22};
    int limiter = sizeof(Array)/sizeof(Array[0]);
    for(int loop = 1; loop<= limiter;loop++)
    {
       index = BinarySearch(Array,limiter+1,4);
    }
    if(index == -1)
    {
        printf("Don't have");
    }
    else
    {
        printf("%d",index);
    }
}
int BinarySearch(int Array[],int limiter,int target)
{
    int left,right,mid;
    left = 0;
    right = limiter - 1;
    do
    {
        mid = (left+right)/2;
        if(target == Array[mid])
        {
            return mid+1;
        }
        else if(target > Array[mid])
        {
            left = mid+1;
        }
        else if(target < Array[mid])
        {
            right = mid - 1;
        }
    }while(left<=right);
    return 0;
}