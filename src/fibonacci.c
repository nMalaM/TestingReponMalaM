#include "../include/fibonacci.h"
#include <stdio.h>
#include <math.h>
using namespace std;

// Method 1: Recursive (Simple but inefficient for large n)
int fibonacciRecursive(int n) {
    if (n <= 1) {
        return n;
    }
    return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
}

// Method 2: Iterative (Efficient)
int fibonacciIterative(int n) {
    if (n <= 1) {
        return n;
    }
    
    int a = 0, b = 1, result = 0;
    for (int i = 2; i <= n; i++) {
        result = a + b;
        a = b;
        b = result;
    }
    return result;
}

// Method 3: Dynamic Programming with Memoization
vector<int> memo;

int fibonacciMemo(int n) {
    if (n <= 1) {
        return n;
    }
    
    if (memo[n] != -1) {
        return memo[n];
    }
    
    memo[n] = fibonacciMemo(n - 1) + fibonacciMemo(n - 2);
    return memo[n];
}

// Method 4: Print Fibonacci Series
void printFibonacciSeries(int n) {
    cout << "Fibonacci series up to " << n << " terms: ";
    int a = 0, b = 1;
    
    if (n >= 1) cout << a << " ";
    if (n >= 2) cout << b << " ";
    
    for (int i = 3; i <= n; i++) {
        int next = a + b;
        cout << next << " ";
        a = b;
        b = next;
    }
    cout << endl;
}

