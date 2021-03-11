pipeline {
    agent any
    stages {
        stage("Build application") {
            steps {
                sh "dotnet build src/Workouter.sln"
                sh "docker build . -t tr0els/workouter"
                withCredentials([[$class: 'UsernamePasswordMultiBinding', credentialsId: 'DockerHub', usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD']])
                {
                    sh 'docker login -u ${USERNAME} -p ${PASSWORD}'
                }
                sh "docker push tr0els/workouter"
            }
        }
        stage("Release to staging") {
            steps {
                sh "docker-compose pull"
                sh "docker-compose up -d"
            }
        }
    }
}