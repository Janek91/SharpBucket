﻿using SharpBucket.EndPoints;

namespace SharpBucket.V1{
    public sealed class SharpBucketV1 : SharpBucket{
        public UserEndPointV1 User(){
            return new UserEndPointV1(this);
        }

        public RepositoryEndPointV1 Repository(string accountName, string repository){
            return new RepositoryEndPointV1(accountName, repository, this);
        }

        public UsersEndpointV1 Users(string accountName){
            return new UsersEndpointV1(accountName, this);
        }
    }
}