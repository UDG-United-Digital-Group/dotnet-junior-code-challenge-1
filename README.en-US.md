# Coding Contest 1 - TreeView

A TreeView component should be implemented in a WebApp. The component should display hierarchically structured data directly in the frontend using the library [jsTree](https://www.jstree.com/docs).

A [Service](Services/DataService.cs) already exists to be able to call up test data. The [Service](Services/DataService.cs) delivers the data in a flat hierarchy; there is no child-parent implementation. All returned data are instances of the class [DataModel](Models/DataModel.cs).

## 1. Objective

For performance reasons, the data in the backend should be prepared accordingly and then rendered in the frontend.

The [Service](Services/DataService.cs) should be expanded so that it structures the data hierarchically and outputs it to the frontend. The structure of the hierarchy should be based on the function

```cpp
CodingContext.Services.DataService.GetGrouping()
```

returned grouping. The order must be followed.

1. Implementation of a function in [DataService](Services/DataService.cs) to create the hierarchy
    - The return value must be an array of the type [TreeViewResult](Models/TreeViewResult.cs).
2. Output of the data in the frontend at the corresponding [location](Views/Home/Index.cshtml) using [jsTree](https://www.jstree.com/docs).
3. Implementation of two buttons to transport data from the left TreeView to the right TreeView at the specified [position](Views/Home/Index.cshtml).
4. If data is transported from the left TreeView to the right TreeView, this must be done on the server side, i.e. hierarchical data for the left and right TreeView must be supplied by the backend.

## 2. Design

The design / layout already exists.

## 3. Implementation

The implementation must be based on the points required under 1. Objective.

Only the [DataService](Services/DataService.cs) should be expanded to include the required functions; the existing functions must not be adapted. All functions should be implemented purely in the backend, grouping / sorting etc. must not be implemented in the front end.

### 3.1 Use of 3rd party libraries

The use of further third-party libraries is not desired or necessary.

### 3.2 Maintainability

Well-structured and documented code is important for implementation. Compliance with current **Best Practices** and **Coding Style Guidelines** (depending on the language / technology used) is desired.

Your code should be **readable** and **understandable** - even for third parties. The program flow should also be traceable.

Keep in mind that you and / or others need to build on this code and expand the project.

## 4. Supply

When you are finished with the task - or have only completed part of the time, you can provide us with your work result as follows:

1. Provide us with the link to your code repository
   - If you don't have one yet, you can get one of the leading providers (e.g. [GitHub](https://github.com/), [GitLab](https://about.gitlab.com/), [Bitbucket](https://bitbucket.org/), [AzureDevOps](https://dev.azure.com/), ...) create an account and make your project available there.
   - Please make sure that the visibility of the repository is set to "Public"

2. If you want to provide a demo of your project, [GitHub Pages](https://pages.github.com/) offers an easy way.