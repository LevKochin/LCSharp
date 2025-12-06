# LCSharp
Приложение тренажёр под leetcode под язык C#

## 1. Упражнения из раздела Quest -> Data Structures and Algorithms [ресурс](https://leetcode.com/quest/data-structures-and-algorithms-quest/)


### Q1 Concatenation of Array

Given an integer array ```nums``` of length ```n```, you want to create an array ```ans``` of length ```2n``` where ```ans[i] == nums[i]``` and ```ans[i + n] === nums[i]``` for ```0 <= i < n``` (**0-indexed**).

Specifically, ```ans``` is the **concatenation** of two ```nums``` arrays.

Return *the array* ```ans```.

**Example 1:**
> **Input:** nums = [1,2,1]  
> **Output:** [1,2,1,1,2,1]  
> **Explanation:** The array ans is formed as follows:  
> ans=[nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]  
> ans=[1,2,1,1,2,1]  

**Example 2:**
> **Input:** nums = [1,3,2,1]  
> **Output:** [1,3,2,1,1,3,2,1]  
> **Explanation:** The array ans is formed as follows:  
> ans = [nums[0], nums[1], nums[2], nums[3], nums[0], nums[1], nums[2], nums[3]]  
> ans = [1,3,2,1,1,3,2,1]  


**Constaraints:**
- ```n == nums.length```
- ```1 <= n <= 1000```
- ```1 <= nums[i] <= 1000```

---

**Задачи:**
- [x] Описать метод, который будет возвращать из исходного массива - ее увеличенную форму [ссылка](https://github.com/LevKochin/LCSharp/blob/main/LCSharp.Array.Library/ArrayConcatenationService.cs)
- [x] Написать тесты для метода, который будут включать примеры из данной задачи [ссылка](https://github.com/LevKochin/LCSharp/blob/main/LCSharp.Array.Tests/ArrayConcatenationTest.cs)

### Q2 Shuffle the Array

Given the array ```nums``` consisting of ```2n``` elements in the form ```[x1, x2,..., xn, yn]```.

*Return the array int the form* ```[x1, y1, x2, y2, ... , xn, yn]```

**Example 1:**
> **Input:** nums = [2,5,1,3,4,7], n = 3  
> **Output:** [2,3,5,4,1,7]  
> **Explanation:** Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7  
> then the answer is [2,3,5,4,1,7]  

**Example 2:**
> **Input:** nums = [1,2,3,4,4,3,2,1], n = 4  
> **Output:** [1,4,2,3,3,2,4,1]  

**Example 3:**
> **Input:** nums = [1,1,2,2], n = 2  
> **Output:** [1,2,1,2]  

---

**Задачи:**
- [x] Описать метод, который будет выполнять перемешивание массива по вводным данным [ссылка](https://github.com/LevKochin/LCSharp/blob/main/LCSharp.Array.Library/ArrayStirrerService.cs)
- [x] Написать тесты для метода, который будут включать примеры из данной задачи [сслыка](https://github.com/LevKochin/LCSharp/blob/main/LCSharp.Array.Tests/ArrayStirrerTest.cs)


### Q3 Max Consecutive Ones

Given a binary array ```nums```, return *the maximum number of consecutive* ```1```'s *in the array* 

**Example 1:**
> **Input:** nums = [1, 1, 0, 1, 1, 1]
> **Output:** 3
> **Explanation:** The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

**Exmaple 2:**
> **Input:** nums = [1, 0, 1, 1, 0, 1]
> **Output:** 2

**Constraints:**
- ```1 <= nums.length <= 10**5```
- ```nums[i]``` is either ```0``` or ```1```.

**Задачи**
- [x] Описать метод, который будет считать последовательное расположение единиц в массиве
- [x] Написать тесты для проверки правильной отработки счётчика