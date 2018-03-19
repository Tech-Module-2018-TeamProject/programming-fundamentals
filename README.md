# programming-fundamentals
## *Programming Fundamentals Repository*

*link to exercises: https://softuni.bg/trainings/resources/officedocument/20482/exercise-problem-descriptions-programming-fundamentals-january-2018*

---
### Problem 1 : Description

---
### Problem 2 : Description

---
### Problem 3 : Description

Write a program, which **converts miles** to **kilometers**. **Format** the output to the **2nd decimal place**.

#### Notes

* **1 mile == 1.60934 kilometers**

#### Examples

------------------------
|**Input**  |**Output**|
| :---      | :---     |
| 60        |96.56     |
| 1         |1.61      |
| 52.1113   |83.86	   |
------------------------

### Problem 4 : Description

Write a program, which reads a food product name, volume, energy content per 100ml and sugar content per 100ml. Calculate the energy and sugar content for the given volume and print them on the console in the following format:

* Name – as per the input  
* Volume – **integer**, **suffixed** by “**ml**” (e.g. “**220ml**”)
* Energy content – **integer**, **suffixed** by “**kca**l” (e.g. “**500kcal**”)
* Sugar content – **integer**, **suffixed** by “**g**” (e.g. “**30g**”;

#### Examples  

-------------------------------------------------------------------------
| **Input**          | **Output**                                       |
| :----              | :---                                             |
| Nuka-Cola          | 220ml Nuka-Cola: 660kcal, 154g sugars            |
| 220                |                                                  |
| 300                |                                                  |
| 70                 |                                                  |
-------------------------------------------------------------------------
| **Input**          | **Output**                                       |
| :----              | :---                                             |
| Ice Cold Nuka-Cola | 250ml Ice Cold Nuka-Cola: 875kcal, 162.5g sugars |
| 250                |                                                  |
| 350                |                                                  |
| 35                 |                                                  |
-------------------------------------------------------------------------
| **Input**          | **Output**                                       |
| :----              | :---                                             |
| Nuka-Cola Quantum  | 350ml Nuka-Cola Quantum: 2100kcal, 490g sugars   |
| 350                |                                                  |
| 600                |                                                  |
| 140                |                                                  |
------------------------------------------------------------------------

---
### Problem 5 : Description
Write a program, which **displays information** about a video game character. You will receive their **name**, **current health**, **maximum health**, **current energy** and **maximum energy** on separate lines. The **current** values will always be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

#### Examples

------------------------------------------------------------------------------------------------
| **Input** | **Output**                                                                       |
| :---      | :---                                                                             |
| Mayro     | Name: Mayro                                                                      |
| 5         | Health: &#124;&#124;&#124;&#124;&#124;&#124;.....&#124;                          |
| 10        | Energy: &#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;.&#124;      |
| 9         |                                                                                  |
| 10        |                                                                                  |
------------------------------------------------------------------------------------------------
| **Input** | **Output**                                                                       |
| :---      | :---                                                                             |
| Bauser    | Name: Bauser                                                                     |
| 8         | Health: &#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124; |
| 20        | Energy: &#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124; |
| 2         |                                                                                  |
| 14        |                                                                                  |
------------------------------------------------------------------------------------------------
| **Input** | **Output**                                                                       |
| :---      | :---                                                                             |
| Loogi     | Name: Loogi                                                                      |
| 8         | Health: &#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;&#124;............&#124; |
| 20        | Energy: &#124;&#124;&#124;............&#124;                                     |
| 2         |                                                                                  |
| 14        |                                                                                  |
------------------------------------------------------------------------------------------------
| **Input** | **Output**                                                                       |
| :---      | :---                                                                             |
| Toad      | Name: Toad                                                                       |
| 8         | Health: &#124;.....&#124;                                                        |
| 20        | Energy: &#124;..........&#124;                                                   |
| 2         |                                                                                  |
| 14        |                                                                                  |
------------------------------------------------------------------------------------------------

#### Hints

* You can print a character **multiple** times, using **new string(character, count**).
