pipeline {
    agent any
    stages {
        stage("Build application") {
            sh "dotnet build src/Workouter.sln"
            sh "docker build . -t boulundeasv/workouter"
            withCredentials([[$class: 'UsernamePasswordMultiBinding', credentialsId: 'DockerHub', usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD']])
            {
                sh 'docker login -u ${USERNAME} -p ${PASSWORD}'
            }
            sh "docker push boulundeasv/workouter"
        }
        stage("Release to staging") {
            steps {
                sh "docker-compose pull"
                sh "docker-compose up -d"
            }
        }
    }
}