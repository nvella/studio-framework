# StudioFramework

StudioFramework library for .NET - implementations of common patterns and architecture for quickly building 'studio' desktop applications.

## What is a studio application?

- A full-featured desktop application following 'tried-and-true' graphical computing metaphors, based upon of a multi-document interface (tabbed or windowed,) and hierarchical navigation.
- First class human interface by both menuing/toolbars and keyboard shortcuts.
- Sane defaults, whilst also providing for extensive configuration via well-discoverable graphical settings.

StudioFramework aims to provide robust components to enable the rapid development of such applications, where some or all of these components may be used. Opinionated patterns are preferred, but never at the cost of inflexibility or hampered discoverability. The aim is to reduce the friction that often presents itself when choosing to embark on a complex desktop software project, so that such paths of implementation become more appealing as compared to their contemporary web-based counterparts.

## Bits and pieces

As mentioned above, StudioFramework will consist of many individual components, where some or all may be used.

- Windowing: Management of documents of windows. An application may either be single- or multi-windowed, and each window may either be single- or multi-'document'. Examples of such metaphor implementations are;

|                | Multi-document  | Single document  |
|----------------|-----------------|------------------|
| **Multi-window**   | Visual Studio   | Word             |
| **Single-window**  | MMC             | Paint            |

Whilst multiple instances of a single-window-multi-document application can be spawned, they do not hold a shared context; documents cannot be be moved from one instance to the other.
- Navigation/Routing
- Hosting

## Architecture

Utilising DI/IoC patterns, StudioFramework aims to fully decouple itself from the 'presentation' layer (i.e., WPF, Avalonia.) A reference presentation implementation for WPF will be provided. 