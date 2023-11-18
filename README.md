# Word Counter

[![CI](https://github.com/harshwardhan1024/wc/actions/workflows/ci.yml/badge.svg?branch=master)](https://github.com/harshwardhan1024/wc/actions/workflows/ci.yml)

A clone of Linux's wc utility for word processing. It calculates a file's word, line, character or byte count.

## Usage

1. Download the binary.
2. Add its path in Environment Variables.
3. Then you can execute the following command.

`wc <file-path> -l`

This will output the number of lines in the specified file.

### Flags
| Flag | Description |
|------|-------------|
| l | Count lines |
| w | Count words |
| m | Count characters |
| c | Count bytes |


You can also pass multiple flags. If no flag is passed then output is similar to `wc <file-path> -l -w -m`.
