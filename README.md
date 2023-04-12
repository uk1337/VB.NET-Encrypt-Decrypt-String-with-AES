# A module in vb.net to encrypt and decrypt a string with AES

This module provides functions to encrypt and decrypt a string using AES encryption in VB.NET.


## Usage

To use this module, simply add the AesEncryption.vb file to your VB.NET project.
Then, you can call the EncryptString and DecryptString functions from anywhere in your code.

### Encrypt a string

```VB.net
Dim plainText As String = "Hello, world!"
Dim encryptedString As String = EncryptString(plainText)
```

### Decrypt a string

```VB.net
Dim encryptedString As String = "NkDj9GmTz0aJyDTTElbj3w=="
Dim decryptedString As String = DecryptString(encryptedString)
```

Note that you should keep the encryption key and initialization vector secret, as anyone with access to these values can decrypt the encrypted string.

## Customization
By default, this module uses a fixed key and initialization vector for encryption. For actual use, you should generate a random key and initialization vector for each encryption operation. You can modify the key and iv variables in the AesEncryption module to use your own values.

## Dependencies
This module depends on the System.Security.Cryptography and System.Text namespaces, which should already be included in a standard VB.NET project.

## Contributing
If you find any issues with this module or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License
This module is licensed under the MIT License.
