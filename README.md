# altwalker-jenkins-example

This is an example of a simple Jenkins Pipeline for AltWalker.

You can find a tutorial on how to setup a Jenkins CI/CD pipeline for AltWalker [here](https://dev.to/robert96/setup-a-jenkins-pipeline-for-your-altwalker-tests-200h).

## Running the tests

```
$ altwalker online tests --language dotnet -m models/model.json "random(vertex_coverage(100))" --report-xml
```

## License

This project is licensed under the [MIT License](LICENSE).