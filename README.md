# Domain-Driven Design - Anemic Model x Rich Model

### Reference: https://thedomaindrivendesign.io/anemic-model-x-rich-model/

My intention is to use like example the scenario of a SCRUM model and be able to show in a practical way the difference between an implementation of Anemic Model and Rich Model.

The use case is:

> "Allow each Backlog Item to be allocated to a Sprint. If it has already been allocated to a different Sprint, it must first be deallocated. After the allocation is complete, notify the interested parties."

The Anemic Model uses a very data-centric approach, not behavioral. It’s not really a domain model.
Note that their entities have no business logic, every rule was directed to Domain Services, entity properties are set without any control, there is no validation after setting these properties, the aggregates do not generate domain events.
Your objects are data containers.

In Rich Model we use the behavior of the domain object that expresses the Ubiquitous Language.
Instead of exposing data attributes to clients, it exposes a behavior that explicitly and clearly indicates that a Client can allocate a Backlog Item to a Sprint.
Without inserting this rich behavior into the Backlog Item, the Client would have to work with events, and this is extremely wrong.

And now, can you see the benefits of working with a Rich Model?

That’s all, folks