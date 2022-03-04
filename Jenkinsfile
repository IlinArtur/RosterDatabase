parameters {
    string(name: 'paramA', defaultValue: 'Hello', description: 'How should I greet the world?')
}

node
{
    
    stage('Hello')
    {
        step{
            echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
        }
    }

    stage('Build'){
        step{
            echo "Building ${params.paramA}"
        }
    }
}