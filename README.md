# SP
 System Programming


<details><summary> 1.Acquaintance .  </summary><p>

---

[Actions with another proccesses](CW/lesson_01/ProcessManipulation "CW\lesson_01\ProcessManipulation")   

---

</p></details>

<details><summary> 2.Thread .  </summary><p>

---

[Basics with Thread(lock,abort,sync, etc.)](CW/lesson_02/ "CW\lesson_02\")   

---

</p></details>


<details><summary> 3.Async.  </summary><p>

- Работа с пулом потоков все время меняется , лучше читать в документации , не стоит привязываться к книгам.
- Вопросы по многопоточности:
    - По архитектуре кода
    - Про поток , пул , лок , мютекс , семафор
- Монитор отличается от лока тем , что в локе внутри есть трай файнали , для завершения процессов ,которые выкинули эксепшн, в мониторе нужно самому оборачивать ,т.к. поток залочит данные
- async await работает про принципу конечного автомата

---

[exp](CW/lesson_03/async_await "CW\lesson_03\async_await")   


[Task.Factory , cancelationToken , invoke example](HW/lesson_03/async_counters "HW\lesson_03\async_counters")   

---

</p></details>

