# Contributing

## Pull requests

Every pull request is squash-merged: all of its commits become one commit on `master`. You can write the commits inside your pull request any way you like.

The title of the pull request becomes the message of that commit and a line in the release notes, which GitHub generates from merged pull requests. The title follows [Conventional Commits](https://www.conventionalcommits.org/): `<type>[(scope)][!]: <description>`. A maintainer may edit the title before merging.

## Commit types

- `feat`: a new feature.
- `fix`: a bug fix.
- `!` after the type: a breaking change, for example `feat(core)!: rename Window.Size`.
- `docs`, `refactor`, `test`, `chore`, `ci`, `style`, `build`, `perf`, `revert`: everything else.

The type does not choose the version: a maintainer sets the version when starting a release.
