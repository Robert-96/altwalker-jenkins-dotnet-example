pipeline {
    agent {
        docker {
            image 'altwalker/altwalker:latest-dotnet-3.1'
            args '-u root:root'
        }
    }
    stages {
        stage('test') {
            steps {
                sh 'altwalker online tests --language dotnet -m models/model.json "random(vertex_coverage(100))" --report-xml || true'
                sh 'cat dotnet-executor.log'
                junit 'report.xml'
            }
        }
    }
}
