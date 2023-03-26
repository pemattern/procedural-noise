# Procedural-Noise
Create deterministic procedural noise using C# 11's new generics math features.

## Creating a noise object
The following code with creates a white noise generator of type double with a specified seed and reads the value at the given position.

```
WhiteNoise<double> whiteNoise = new WhiteNoise<double>(42);
double value = whiteNoise.Get(1, 2, 3);
```
## Generics
Currently, only numeric types that implement the IFloatingPoint<T> and ITrigonometicFunctions<TSelf> interfaces are supported, these include:
```
float
double
System.Half
System.Numerics.IBinaryFloatingPointIeee754<TSelf>
System.Numerics.IFloatingPointIeee754<TSelf>
System.Runtime.InteropServices.NFloat
```
## Dimensions
You can get values by inputting 1D, 2D and 3D coordinates.
