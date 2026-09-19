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

<h2></h2>

<br>
<br>


# UnityGetID (ma in italiano)

Un'API unificata per `GetInstanceID()` e `GetEntityId()`, progettata per eliminare la necessità di utilizzare codice specifico per versione quando si lavora con diverse versioni di Unity.

## Cosa fa?

<h5>
  Unity 6000.4 ha introdotto `GetEntityId()` e il tipo `EntityId`, creando un problema di compatibilità per il codice che deve funzionare su diverse versioni di Unity.
</h5>
<br>
<h5>
  Normalmente, sarebbe necessario scrivere:
</h5>

```csharp
#if UNITY_6000_4_OR_NEWER
EntityId id = gameObject.GetEntityId();
#else
int id = gameObject.GetInstanceID();
#endif
```

<h5> UnityGetID elimina la necessità di utilizzare questi controlli di versione. Con UnityGetID, puoi semplicemente scrivere: </h5>

```csharp
EntityId id = gameObject.GetID();
```

<h5> Lo stesso codice può quindi essere utilizzato nelle versioni di Unity supportate. </h5> <br>

## Come funziona
<h5> UnityGetID fornisce un metodo extension unificato `GetID()`.

Nelle versioni di Unity che supportano EntityId, GetID() restituisce direttamente l'EntityId nativo di Unity:
</h5>

```csharp
EntityId id = gameObject.GetID();
```

<h5> Nelle versioni precedenti di Unity, UnityGetID fornisce un proprio `struct` `EntityId` compatibile.

Il vecchio EntityId contiene internamente un int e fornisce conversioni implicite tra EntityId e int, permettendo di utilizzarlo in modo simile al tipo nativo:
</h5>

```csharp
EntityId id = gameObject.GetID();

int value = id;
```

<h5> Questo permette di utilizzare il tipo `EntityId` anche nelle versioni di Unity in cui non è presente nativamente. </h5> <br>

## Installazione

Posiziona il file "UnityGetID.dll" dove vuoi all'interno della cartella `Assets` del progetto. <br>
Semplicemente NON inserirlo all'interno di una cartella `Editor` o di una sua sottocartella.
