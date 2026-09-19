# UnityGetID

A unified API for `GetInstanceID()` and `GetEntityId()`, designed to eliminate version-specific code when working with different Unity versions.

## What does it do?

<h5>
  Unity 6000.4 introduced `GetEntityId()` and the `EntityId` type, creating a compatibility problem for code that needs to work across different Unity versions.
</h5>
<br>
<h5>
  Normally, you would need to write:
</h5>

```csharp
#if UNITY_6000_4_OR_NEWER
EntityId id = gameObject.GetEntityId();
#else
int id = gameObject.GetInstanceID();
#endif
```

<h5>
UnityGetID removes the need for these version checks. With UnityGetID, you can simply write:
</h5>

```csharp
EntityId id = gameObject.GetID();
```

<h5>
The same code can then be used across supported Unity versions.
</h5>


<br>


## How it works

<h5>
UnityGetID provides a unified `GetID()` extension method.

On Unity versions that support `EntityId`, `GetID()` directly returns Unity's native `EntityId`:
</h5>

```csharp
EntityId id = gameObject.GetID();
```

<h5>
On older Unity versions, UnityGetID provides its own compatible `EntityId` struct.

The legacy `EntityId` internally stores an `int` and provides implicit conversions between `EntityId` and `int`, allowing it to be used similarly to the native type:
</h5>

```csharp
EntityId id = gameObject.GetID();

int value = id;
```

<h5>
This allows you to use the `EntityId` type even on Unity versions where it does not natively exist.
</h5>

<br>

## Installation

Place the "UnityGetID.dll" file everywhere you want, inside your project's `Assets` folder. <br>
Just DON'T inside an `Editor` folder or `Editor`'s subfolder.

