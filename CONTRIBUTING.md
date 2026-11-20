# Contributing

## Pull requests

Every pull request is squash-merged: all of its commits become one commit on `master`. You can write the commits inside your pull request any way you like.

The title of the pull request becomes the message of that one commit, so it has to follow [Conventional Commits](https://www.conventionalcommits.org/): `<type>[(scope)][!]: <description>`. A maintainer may edit the title before merging.

## Commit types

The type decides whether the change appears in the release notes and how it moves the version.

| Type | Effect on the version |
| --- | --- |
| `feat` | minor |
| `fix` | patch |
| `!` after the type, for a breaking change | minor before 1.0, major after 1.0 |
| `docs`, `refactor`, `test`, `chore`, `ci`, `style`, `build`, `perf`, `revert` | no release on their own |

Examples: `feat(opengl): add debug contexts`, `fix: release the device context on dispose`, `feat(core)!: rename Window.Size`.
