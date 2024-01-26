# hc-requires-opt-in

Implementation of a `requiresOptIn` directive for Hot Chocolate.

- `dotnet watch --no-hot-reload`
- Query (good):

    ```gql
    {
        book {
            title @optIn(feature: "test")
        }
    }
    ```
- Query (bad #1):

    ```gql
    {
        book {
            title
        }
    }
    ```
- Query (bad #2):

    ```gql
    {
        book {
            title @optIn(feature: "notTest")
        }
    }
    ```