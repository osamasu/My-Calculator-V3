<div align="center">

# 🧮 My Calculator V3

**A sleek, themeable Windows Forms calculator built in C# — with a delegate-driven arithmetic engine under the hood.**

![C#](https://img.shields.io/badge/language-C%23-239120?logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet&logoColor=white)
![Platform](https://img.shields.io/badge/platform-Windows-0078D6?logo=windows&logoColor=white)
![WinForms](https://img.shields.io/badge/UI-WinForms-blueviolet)
![Status](https://img.shields.io/badge/status-active-brightgreen)

</div>

---

## 📸 Screenshots

<div align="center">
<table>
<tr>
<td align="center"><img src="https://github.com/osamasu/My-Calculator-V3/assets/97795269/34224881-fcea-4d73-9541-20804d1dc751" width="380"/><br/><sub>Calculator UI</sub></td>
<td align="center"><img src="https://github.com/osamasu/My-Calculator-V3/assets/97795269/eca9a252-6153-4e2f-b362-1a383752b228" width="380"/><br/><sub>UI Customization</sub></td>
</tr>
</table>
</div>

---

## ✨ Overview

**My Calculator V3** is a desktop calculator built with Windows Forms and C#. Beyond basic arithmetic, it lets you **live-theme the interface** — recoloring buttons, the display, and background panels on the fly — and evaluates chained expressions (`5 + 3 * 2 =`) using a clean **stack-based expression engine** with **delegate-driven** operator dispatch.

It started as a learning project focused on practicing C# delegates: each math operator is wired to its implementation through a `delegate`, rather than a hard-coded `switch` statement — a small but deliberate architectural choice, called out in the project's own commit history as a "delegation challenge."

## 🚀 Features

- ➕➖✖️➗ **Chained arithmetic** — `+`, `-`, `*`, `/` evaluated left-to-right via a two-stack (numbers/operators) engine
- ⌨️ **Full keyboard support** — number pad, operators, `Enter` to evaluate, `Backspace` to delete, `C` to clear, decimal key
- 🔢 **Decimal input handling** with in-progress fractional digit entry
- 🎨 **Live UI customization** — recolor number buttons, the result display, the calculator panel, and the window background via a built-in color picker
- 🧹 **Clear / Delete / Backspace** controls with running equation display
- ℹ️ **About dialog** with clickable developer contact links (email, LinkedIn, GitHub)
- 🖥️ **DPI-aware rendering** for crisp display on high-resolution screens

## 🏗️ Architecture

The app's core idea is separating **what** operation runs from **how** it's selected:

```csharp
// clsCalculator.cs
public delegate float delOnMathOperation(float Num1, float Num2);

public clsCalculator(delOnMathOperation MathOperation) => this.OnMathOperation = MathOperation;

public float PerformOperation(float EffectedNumber, float Number)
    => OnMathOperation.Invoke(EffectedNumber, Number);
```

Each operator button (`+`, `-`, `*`, `/`) is mapped in `Calculator.cs` to its own `clsCalculator` instance, constructed with a delegate pointing at a plain static function (`Add`, `Subtract`, `Multiply`, `Divide`):

```csharp
private Dictionary<char, clsCalculator> DOperations = new Dictionary<char, clsCalculator>
{
    { '+', new clsCalculator(Add) },
    { '-', new clsCalculator(Subtract) },
    { '*', new clsCalculator(Multiply) },
    { '/', new clsCalculator(Divide) }
};
```

Expression evaluation itself uses two stacks — `Stack<float>` for operands and `Stack<char>` for operators — so each new operator press folds the previous pending calculation into a running result before pushing the next one.

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.8 |
| UI | Windows Forms |
| Icons | [FontAwesome.Sharp](https://www.nuget.org/packages/FontAwesome.Sharp) |

## 📦 Getting Started

### Prerequisites

- Windows with **Visual Studio 2019/2022** (Desktop development with .NET Framework workload)
- **.NET Framework 4.8** Developer Pack

### Clone & Build

```bash
git clone https://github.com/osamasu/My-Calculator-V3.git
```

1. Open `My Calculator V4.sln` in Visual Studio.
2. The project references **FontAwesome.Sharp** via a local `HintPath` — if it fails to resolve, install it via NuGet:
   ```powershell
   Install-Package FontAwesome.Sharp
   ```
3. Build and run (`F5`) — the calculator opens directly to the main form.

## ⌨️ Usage

| Action | Mouse | Keyboard |
|---|---|---|
| Enter digits | Number buttons | `0`–`9` (numpad) |
| Decimal point | `.` button | `Decimal` key |
| Add / Subtract / Multiply / Divide | Operator buttons | `+`, `-`, `*`, `/` (numpad) |
| Evaluate | `=` button | `Enter` |
| Clear all | `C` button | `C` |
| Delete last entry | `⌫` button | `Backspace` |
| Customize theme | Menu → UI Controller | — |
| Reset app | Menu → Reset | — |

## 📂 Project Structure

```
My-Calculator-V3/
├── Calculator.cs / Calculator.Designer.cs   # Main form: input handling, display, keyboard shortcuts
├── clsCalculator.cs                         # Delegate-based arithmetic engine
├── UI Customasation.cs                      # Live color-theming dialog
├── About.cs                                 # Developer info / contact dialog
├── Program.cs                               # Application entry point, DPI awareness
├── Resources/                                # Icons and screenshots
└── My Calculator V4.sln / .csproj            # Solution and project files
```

## 🗺️ Known Limitations

- Expressions evaluate strictly **left-to-right** — no operator precedence or parentheses
- Uses `float` precision, which may introduce minor rounding on complex chains
- No automated test suite yet

## 👤 Author

**Osama Thabit Mohammed**

- 📧 [Osamataher306@Outlook.com](mailto:Osamataher306@Outlook.com)
- 💼 [LinkedIn](https://www.linkedin.com/in/osama-thabit-mohammed)
- 🐙 [GitHub — @osamasu](https://github.com/osamasu)
