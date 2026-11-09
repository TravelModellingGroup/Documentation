# Script a log message in a loop

The **Log Each Execute Iteration** interactive tutorial demonstrates a scripted parameter in a small model. It uses an `Execute` module to repeat a logging action and sets `CurrentIteration` to the zero-based iteration number. The tutorial scripts the log message as `"Iteration: " + CurrentIteration`; with three iterations and parallel execution off, the log shows iteration numbers 0, 1, and 2.

To open the tutorial, choose **Help** > **Interactive Tutorial…** in XTMF2, select **Log Each Execute Iteration**, then choose **Start Tutorial**. See [Run XTMF2 interactive tutorials](estimation-calibration.md) for the full launch instructions.

## Values available to expressions

XTMF2's parameter expression language can read model-system variables by their configured names. Variables can be backed by parameter nodes or by supported function-instance and function-parameter values. The supported value types are:

| Expression type | Example | Notes |
| --- | --- | --- |
| `int` | `CurrentIteration` | 32-bit integer; `Execute.Current Iteration` starts at 0. |
| `float` | `scale` | Single-precision number. |
| `bool` | `isEnabled` | Boolean value, written as `true` or `false`. |
| `string` | `"Iteration: "` | Text literal, enclosed in double quotes. |

Use the variable's exact model-system name. The expression's result type must match the type expected by the parameter. For example, a scripted `Message` value must evaluate to a `string`.

## Supported operations

The expression parser supports these operators:

| Operator | Operation and type rules |
| --- | --- |
| `+` | Adds two `int` values or two `float` values. If either operand is a `string`, concatenates the operands as text; this is how the tutorial adds an integer iteration number to a string prefix. |
| `-`, `*`, `/`, `^` | Subtract, multiply, divide, or raise to a power. Both operands must have the same numeric type (`int` or `float`). Integer division returns an integer result. |
| `<`, `<=`, `>`, `>=` | Compare two `int` values or two `float` values; the result is `bool`. |
| `==`, `!=` | Compare matching `int`, `float`, or `bool` values; the result is `bool`. |
| `&&`, `||`, `!` | Boolean AND, OR, and NOT; operands must be `bool`. |
| `condition ? value1 : value2` | Choose between matching `int`, `float`, or `string` values using a `bool` condition. |

Use parentheses to group parts of an expression. The parser does not provide a general-purpose C# environment: method calls such as `CurrentIteration.ToString()` and the modulo operator (`%`) are not supported. Use string concatenation to include a number in text.

For the module's role and configuration, see the [Scripted Parameter reference](../modules/XTMF2/RuntimeModules/ScriptedParameter.md).
