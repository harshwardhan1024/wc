# Word Counter

A clone of Linux's wc utility for word processing. It calculates a file's word, line, character or byte count.

# How to use

- Download the binary.
- Add its path in Environment Variables.
- Then you can execute the following commands.

Count number of **lines** in a file.

`wc <file-path> -l`

Count number of **words** in a file.

`wc <file-path> -w`

Count number of **characters** in a file.

`wc <file-path> -m`

Count number of **bytes** in a file.

`wc <file-path> -c`

You can also pass multiple flags. If no flag is passed then output is similar to `wc <file-path> -l -w -m`.
