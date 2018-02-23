# dp-strategy
Design Patterns - Strategy

# Scenario
A company can have a factory. If company has a factory, it can produce product.
If Company wants to change its factory, we need not to change `Company Class`.

#### Example
```csharp

// Microsoft and Hp Companies produce computer. Also, Microsoft Company produces coffee.

Company microsoft = new Company("Microsoft");
            
microsoft.setFactory(new ComputerFactory("Windows"));
microsoft.Produce();

microsoft.setFactory(new CoffeeFactory("Starbucks"));
microsoft.Produce();

Company hp = new Company("Hewlett Packard");
hp.setFactory(new CoffeeFactory("Federal Coffee"));
hp.Produce();

```
