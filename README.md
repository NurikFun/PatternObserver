# PatternObserver

![Overall picture](http://blog.lukaszewski.it/wp-content/uploads/2013/02/observer_pattern.png)

1. Паттерн Наблюдатель определяет отношение «один-ко-многим» между объектами таким образом, что при изменении состояния одного объекта происходит автоматическое оповещение и обновление всех зависимых объектов
2. Субъекты обновляют наблюдателей через единый интерфейс.
3. Субъект ничего не знает о наблюдателях — кроме того, что они реализуют интерфейс Observer
4. При использовании паттерна возможен как запрос, так и активная доставка данных от субъекта (запрос считается более «правильным»).
5. Работа кода не должна зависеть от порядка оповещения наблюдателей.
