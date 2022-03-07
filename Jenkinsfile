parameters {
    string(name: 'paramA', defaultValue: 'Hello', description: 'How should I greet the world?')
}

node
{
    
    stage('Hello')
    {
        echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
    }

    stage('Build'){
        echo "Building ${params.paramA}"
    }
}