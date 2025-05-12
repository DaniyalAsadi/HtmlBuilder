# HtmlBuilder

A lightweight and extensible HTML element builder for .NET developers. Designed with clean and fluent syntax for composing HTML elements dynamically in C# with full support for nesting, attributes, and rendering.

---

## ✨ Features

- Dynamic creation of HTML elements via fluent C# API  
- Full support for nesting, attributes, and inner content  
- Ideal for building reusable HTML components  
- Easily extendable with custom rendering logic  
- Built with SOLID principles and DDD mindset  

---

## 📦 Installation

Install the NuGet package:

```bash
dotnet add package HtmlBuilder
```
Or via the NuGet Package Manager:

```powershell
Install-Package HtmlBuilder
```

## 🚀 Quick Start
```csharp
var div = HtmlBuilder.Div(div =>
        {
            div.Div(x => x.H1(h1 =>
            {
                h1.SetContent("Hello - World")
                    .SetId("id")
                    .AddClass("col-md-4");

            }))
            .Div(x => x.H2(h2 =>
            {
                h2.SetContent("GoodBye - World")
                    .SetId("id")
                    .AddClass("col-md-3");
            }));
        });
string html = div.ToString();
Console.WriteLine(html);
```
### Output:

```html
<div>
    <div>
        <h1 id="id"> Hello - World </h1>
    </div>
    <div>
        <h2 id="id"> GoodBye - World </h2>
    </div>
</div>
```

## 📁 Project Structure
```bash
HtmlBuilder/
├── src/HtmlBuilder/           # Core library
├── tests/HtmlBuilder.Tests/   # Unit tests using xUnit
├── HtmlBuilder.sln            # Solution file
└── README.md                  # This file
```
## 🧪 Running Tests
```bash
dotnet test
```
## 📚 Documentation
Coming soon — advanced usage and extension patterns will be documented in the Wiki.

## 🤝 Contributing
Contributions are welcome! Feel free to submit issues or pull requests.
For major changes, please open an issue first to discuss what you would like to change.

## 📄 License
MIT License

Copyright (c) 2025 DaniyalAsadi

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
