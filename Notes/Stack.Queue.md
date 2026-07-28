\#Stack \& Queue Operations (Step by Step)



\---



\# Stack (LIFO)



\*\*Last In First Out\*\*



> آخر عنصر يدخل هو أول عنصر يخرج.



\---



\## 1) Push (Insert)



\*\*الهدف:\*\* إضافة عنصر جديد أعلى الـ Stack.



\### الخطوات



1\. تأكد أن الـ Stack ليس ممتلئًا (Overflow).

2\. زوّد قيمة `Top` بمقدار 1.

3\. ضع العنصر الجديد في `Stack\[Top]`.

4\. انتهت العملية.



\*\*Pseudo Code\*\*



```text

IF Top == MAX-1

&#x20;   Overflow

ELSE

&#x20;   Top = Top + 1

&#x20;   Stack\[Top] = Item

END

```



\---



\## 2) Pop (Delete)



\*\*الهدف:\*\* حذف آخر عنصر تمت إضافته.



\### الخطوات



1\. تأكد أن الـ Stack ليس فارغًا (Underflow).

2\. احفظ قيمة `Stack\[Top]` إذا كنت تحتاجها.

3\. قلّل قيمة `Top` بمقدار 1.

4\. انتهت العملية.



\*\*Pseudo Code\*\*



```text

IF Top == -1

&#x20;   Underflow

ELSE

&#x20;   Item = Stack\[Top]

&#x20;   Top = Top - 1

END

```



\---



\## 3) Peek (Top)



\*\*الهدف:\*\* عرض العنصر الموجود أعلى الـ Stack بدون حذفه.



\### الخطوات



1\. تأكد أن الـ Stack ليس فارغًا.

2\. اعرض قيمة `Stack\[Top]`.



\---



\## 4) IsEmpty()



```text

IF Top == -1

&#x20;   Stack is Empty

ELSE

&#x20;   Stack is NOT Empty

```



\---



\## 5) IsFull()



```text

IF Top == MAX-1

&#x20;   Stack is Full

ELSE

&#x20;   Stack is NOT Full

```



\---



\# Queue (FIFO)



\*\*First In First Out\*\*



> أول عنصر يدخل هو أول عنصر يخرج.



\---



\## 1) Enqueue (Insert)



\*\*الهدف:\*\* إضافة عنصر في نهاية الـ Queue.



\### الخطوات



1\. تأكد أن الـ Queue ليس ممتلئًا.

2\. إذا كانت أول إضافة:



&#x20;  \* اجعل Front = 0.

3\. زوّد قيمة Rear بمقدار 1.

4\. ضع العنصر في Queue\[Rear].

5\. انتهت العملية.



\*\*Pseudo Code\*\*



```text

IF Rear == MAX-1

&#x20;   Overflow

ELSE

&#x20;   IF Front == -1

&#x20;       Front = 0

&#x20;   ENDIF



&#x20;   Rear = Rear + 1

&#x20;   Queue\[Rear] = Item

END

```



\---



\## 2) Dequeue (Delete)



\*\*الهدف:\*\* حذف أول عنصر دخل الـ Queue.



\### الخطوات



1\. تأكد أن الـ Queue ليست فارغة.

2\. احفظ العنصر الموجود عند Front.

3\. إذا كان يوجد عنصر واحد فقط:



&#x20;  \* Front = Rear = -1

4\. غير ذلك:



&#x20;  \* Front = Front + 1

5\. انتهت العملية.



\*\*Pseudo Code\*\*



```text

IF Front == -1

&#x20;   Underflow

ELSE

&#x20;   Item = Queue\[Front]



&#x20;   IF Front == Rear

&#x20;       Front = Rear = -1

&#x20;   ELSE

&#x20;       Front = Front + 1

&#x20;   ENDIF

END

```



\---



\## 3) Front



يعرض أول عنصر.



```text

Return Queue\[Front]

```



\---



\## 4) Rear



يعرض آخر عنصر.



```text

Return Queue\[Rear]

```



\---



\## 5) IsEmpty()



```text

IF Front == -1

&#x20;   Queue is Empty

ELSE

&#x20;   Queue is NOT Empty

```



\---



\## ملخص سريع



\### Stack



\* Push ➜ زيادة Top ثم إدخال العنصر.

\* Pop ➜ أخذ العنصر ثم تقليل Top.

\* Peek ➜ قراءة Top فقط.



\---



\### Queue



\* Enqueue ➜ زيادة Rear ثم إدخال العنصر.

\* Dequeue ➜ حذف من Front ثم تحريك Front للأمام.

\* Front ➜ أول عنصر.

\* Rear ➜ آخر عنصر.



\---



\# الفرق بين Stack و Queue



| Stack          | Queue           |

| -------------- | --------------- |

| LIFO           | FIFO            |

| Push           | Enqueue         |

| Pop            | Dequeue         |

| الإضافة من Top | الإضافة من Rear |

| الحذف من Top   | الحذف من Front  |



