/* Error: Undefined variable.
 *    ,
 * 12 |   font-family: $font-principal;
 *    |                ^^^^^^^^^^^^^^^
 *    '
 *   scss\_reset.scss 12:16  @use
 *   scss\styles.scss 5:1    root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: Undefined variable.\a    \2577 \a 12 \2502    font-family: $font-principal;\d\a    \2502                 ^^^^^^^^^^^^^^^\a    \2575 \a   scss\\_reset.scss 12:16  @use\a   scss\\styles.scss 5:1    root stylesheet";
}
