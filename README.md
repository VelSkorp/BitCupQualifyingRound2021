# BitCupQualifyingRound2021
## Задание отборочного этапа олимпиады BIT-Cup

### Работа с git и обработка результатов

- Перед началом работы над задачей хакатона нужно сделать форк от репозитория с заданием на гитхабе (про форки вспомнить можно [по материлам GitHub](https://docs.github.com/en/get-started/quickstart/fork-a-repo).
- Если с форком возникают проблемы - можно создать персональный репозиторий. В таком случае, репозиторий должен быть в аккаунте участника на гитхаб, проект с именем 
BitCupQualifyingRound2021-[FistName_LastName].
- Приветствуются регулярные комиты по мере написания кода - в репозитории с выполненным заданием должно быть не меньше 5 комитов с осмысленным commit message.
- Ссылку на репозиторий с выполненным заданием и данные участника после завершения работы над проектом отправить через форму: 
https://forms.office.com/r/P12NyzcD2t.
Форма открывается для доступа и закрывается автоматически в соотвествии с дедлайнами для отборочного тура, установленными организаторами (23:59:59 14 ноября 2021г.).
- Степень готовности задания может быть разной, важно ***до наступления дедлайна*** отправить через форму ссылку на репозиторий с результатами "как есть".

## Общие требования

- Использовать библиотеки Selenium WebDriver или его обертки для своего языка программирования. 
- Тест раннер (JS/Python) и unit testing framework можно выбрать по своему усмотрению. 
- Соблюдать принципы clean code и модели Page Object. 
- Классы в репозитории разложить по пакетам (Java), проектам (C#) или папкам (JS) в соответствии с логикой выполнения задания. 

## Содержание задания

1. Открыть https://cloud.google.com/ 
2. Нажав кнопку поиска по порталу вверху страницы, ввести в поле поиска"Google Cloud Platform Pricing Calculator".
3. Запустить поиск, нажав кнопку поиска.
4. В результатах поиска кликнуть "Google Cloud Platform Pricing Calculator" и перейти на страницу калькулятора.
5. Активировать раздел COMPUTE ENGINE вверху страницы.
6. Заполнить форму следующими данными (все остальные поля формы оставить так как есть):
##### Раздел Instances
    - Number of instances: 4
    - Operating System / Software: Free: Debian, CentOS, CoreOS, Ubuntu, or BYOL (Brong Your Own License)
    - Machine Class: Regular
    - Machine type: e2-standard-8 (vCPUs: 8, RAM: 32 GB)
7. Нажать ADD TO ESTIMATE.
##### Раздел Sole-tenant nodes
    - Number of nodes: 1
    - Выбрать Add GPUs
        - Number of GPUs: 8
        - GPU type: NVIDIA Tesla V100
    - Выбрать CPU Overcommit
        - Local SSD: 24x375 Gb
        - Datacenter location: Los Angeles (us-west2)
        - Commited usage: 1 Year
8. Нажать ADD TO ESTIMATE.
9. Выбрать пункт EMAIL ESTIMATE.
10. В новой вкладке открыть https://yopmail.com/ или аналогичный сервис для генерации временных email'ов.
11. Скопировать почтовый адрес сгенерированный в yopmail.com
12. Вернуться в калькулятор, в поле Email ввести адрес из предыдущего пункта.
13. Нажать SEND EMAIL.
14. Дождаться письма с рассчетом стоимости и проверить значение Total Estimated Monthly Cost в письме совпадает с тем, что отображается в калькуляторе.

## Рекомендации

- При выполнении задания используйте материалы тренинга WebDriver (https://learn.epam.com/detailsPage?id=93e65671-c99b-42d7-ae15-f77a60cdfa53).
- Дополнительные материалы для C#
  * https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
  * https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/
  * https://www.automatetheplanet.com/page-object-pattern/
  * https://dzone.com/articles/selenium-c-tutorial-using-implicit-wait-in-seleniu
  * https://www.lambdatest.com/blog/explicit-fluent-wait-in-selenium-c/
  * https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2019
- Дополнительные материалы для JS
  * https://www.selenium.dev/selenium/docs/api/javascript/index.html
  * https://blog.dmitrypodgorniy.com/all/singlton-na-javascript/
  * https://www.selenium.dev/documentation/webdriver/
