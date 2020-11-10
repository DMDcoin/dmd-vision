using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.Contracts.StakingHbbftCoins.ContractDefinition;

namespace DMDVision.Contracts.StakingHbbftCoins
{
    public partial class StakingHbbftCoinsService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, StakingHbbftCoinsDeployment stakingHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<StakingHbbftCoinsDeployment>().SendRequestAndWaitForReceiptAsync(stakingHbbftCoinsDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, StakingHbbftCoinsDeployment stakingHbbftCoinsDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<StakingHbbftCoinsDeployment>().SendRequestAsync(stakingHbbftCoinsDeployment);
        }

        public static async Task<StakingHbbftCoinsService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, StakingHbbftCoinsDeployment stakingHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, stakingHbbftCoinsDeployment, cancellationTokenSource);
            return new StakingHbbftCoinsService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public StakingHbbftCoinsService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> MAX_CANDIDATESQueryAsync(MAX_CANDIDATESFunction mAX_CANDIDATESFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_CANDIDATESFunction, BigInteger>(mAX_CANDIDATESFunction, blockParameter);
        }

        
        public Task<BigInteger> MAX_CANDIDATESQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_CANDIDATESFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> AddPoolRequestAsync(AddPoolFunction addPoolFunction)
        {
             return ContractHandler.SendRequestAsync(addPoolFunction);
        }

        public Task<TransactionReceipt> AddPoolRequestAndWaitForReceiptAsync(AddPoolFunction addPoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addPoolFunction, cancellationToken);
        }

        public Task<string> AddPoolRequestAsync(string miningAddress, byte[] publicKey, byte[] ip)
        {
            var addPoolFunction = new AddPoolFunction();
                addPoolFunction.MiningAddress = miningAddress;
                addPoolFunction.PublicKey = publicKey;
                addPoolFunction.Ip = ip;
            
             return ContractHandler.SendRequestAsync(addPoolFunction);
        }

        public Task<TransactionReceipt> AddPoolRequestAndWaitForReceiptAsync(string miningAddress, byte[] publicKey, byte[] ip, CancellationTokenSource cancellationToken = null)
        {
            var addPoolFunction = new AddPoolFunction();
                addPoolFunction.MiningAddress = miningAddress;
                addPoolFunction.PublicKey = publicKey;
                addPoolFunction.Ip = ip;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addPoolFunction, cancellationToken);
        }

        public Task<bool> AreStakeAndWithdrawAllowedQueryAsync(AreStakeAndWithdrawAllowedFunction areStakeAndWithdrawAllowedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AreStakeAndWithdrawAllowedFunction, bool>(areStakeAndWithdrawAllowedFunction, blockParameter);
        }

        
        public Task<bool> AreStakeAndWithdrawAllowedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AreStakeAndWithdrawAllowedFunction, bool>(null, blockParameter);
        }

        public Task<BigInteger> CandidateMinStakeQueryAsync(CandidateMinStakeFunction candidateMinStakeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CandidateMinStakeFunction, BigInteger>(candidateMinStakeFunction, blockParameter);
        }

        
        public Task<BigInteger> CandidateMinStakeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CandidateMinStakeFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> ClaimOrderedWithdrawRequestAsync(ClaimOrderedWithdrawFunction claimOrderedWithdrawFunction)
        {
             return ContractHandler.SendRequestAsync(claimOrderedWithdrawFunction);
        }

        public Task<TransactionReceipt> ClaimOrderedWithdrawRequestAndWaitForReceiptAsync(ClaimOrderedWithdrawFunction claimOrderedWithdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(claimOrderedWithdrawFunction, cancellationToken);
        }

        public Task<string> ClaimOrderedWithdrawRequestAsync(string poolStakingAddress)
        {
            var claimOrderedWithdrawFunction = new ClaimOrderedWithdrawFunction();
                claimOrderedWithdrawFunction.PoolStakingAddress = poolStakingAddress;
            
             return ContractHandler.SendRequestAsync(claimOrderedWithdrawFunction);
        }

        public Task<TransactionReceipt> ClaimOrderedWithdrawRequestAndWaitForReceiptAsync(string poolStakingAddress, CancellationTokenSource cancellationToken = null)
        {
            var claimOrderedWithdrawFunction = new ClaimOrderedWithdrawFunction();
                claimOrderedWithdrawFunction.PoolStakingAddress = poolStakingAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(claimOrderedWithdrawFunction, cancellationToken);
        }

        public Task<BigInteger> DelegatorMinStakeQueryAsync(DelegatorMinStakeFunction delegatorMinStakeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DelegatorMinStakeFunction, BigInteger>(delegatorMinStakeFunction, blockParameter);
        }

        
        public Task<BigInteger> DelegatorMinStakeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DelegatorMinStakeFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> DelegatorStakeSnapshotQueryAsync(DelegatorStakeSnapshotFunction delegatorStakeSnapshotFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DelegatorStakeSnapshotFunction, BigInteger>(delegatorStakeSnapshotFunction, blockParameter);
        }

        
        public Task<BigInteger> DelegatorStakeSnapshotQueryAsync(string returnValue1, string returnValue2, BigInteger returnValue3, BlockParameter blockParameter = null)
        {
            var delegatorStakeSnapshotFunction = new DelegatorStakeSnapshotFunction();
                delegatorStakeSnapshotFunction.ReturnValue1 = returnValue1;
                delegatorStakeSnapshotFunction.ReturnValue2 = returnValue2;
                delegatorStakeSnapshotFunction.ReturnValue3 = returnValue3;
            
            return ContractHandler.QueryAsync<DelegatorStakeSnapshotFunction, BigInteger>(delegatorStakeSnapshotFunction, blockParameter);
        }

        public Task<byte[]> GetPoolInternetAddressQueryAsync(GetPoolInternetAddressFunction getPoolInternetAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolInternetAddressFunction, byte[]>(getPoolInternetAddressFunction, blockParameter);
        }

        
        public Task<byte[]> GetPoolInternetAddressQueryAsync(string poolAddress, BlockParameter blockParameter = null)
        {
            var getPoolInternetAddressFunction = new GetPoolInternetAddressFunction();
                getPoolInternetAddressFunction.PoolAddress = poolAddress;
            
            return ContractHandler.QueryAsync<GetPoolInternetAddressFunction, byte[]>(getPoolInternetAddressFunction, blockParameter);
        }

        public Task<byte[]> GetPoolPublicKeyQueryAsync(GetPoolPublicKeyFunction getPoolPublicKeyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolPublicKeyFunction, byte[]>(getPoolPublicKeyFunction, blockParameter);
        }

        
        public Task<byte[]> GetPoolPublicKeyQueryAsync(string poolAddress, BlockParameter blockParameter = null)
        {
            var getPoolPublicKeyFunction = new GetPoolPublicKeyFunction();
                getPoolPublicKeyFunction.PoolAddress = poolAddress;
            
            return ContractHandler.QueryAsync<GetPoolPublicKeyFunction, byte[]>(getPoolPublicKeyFunction, blockParameter);
        }

        public Task<List<string>> GetPoolsQueryAsync(GetPoolsFunction getPoolsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsFunction, List<string>>(getPoolsFunction, blockParameter);
        }

        
        public Task<List<string>> GetPoolsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsFunction, List<string>>(null, blockParameter);
        }

        public Task<List<string>> GetPoolsInactiveQueryAsync(GetPoolsInactiveFunction getPoolsInactiveFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsInactiveFunction, List<string>>(getPoolsInactiveFunction, blockParameter);
        }

        
        public Task<List<string>> GetPoolsInactiveQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsInactiveFunction, List<string>>(null, blockParameter);
        }

        public Task<GetPoolsLikelihoodOutputDTO> GetPoolsLikelihoodQueryAsync(GetPoolsLikelihoodFunction getPoolsLikelihoodFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolsLikelihoodFunction, GetPoolsLikelihoodOutputDTO>(getPoolsLikelihoodFunction, blockParameter);
        }

        public Task<GetPoolsLikelihoodOutputDTO> GetPoolsLikelihoodQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolsLikelihoodFunction, GetPoolsLikelihoodOutputDTO>(null, blockParameter);
        }

        public Task<List<string>> GetPoolsToBeElectedQueryAsync(GetPoolsToBeElectedFunction getPoolsToBeElectedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeElectedFunction, List<string>>(getPoolsToBeElectedFunction, blockParameter);
        }

        
        public Task<List<string>> GetPoolsToBeElectedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeElectedFunction, List<string>>(null, blockParameter);
        }

        public Task<List<string>> GetPoolsToBeRemovedQueryAsync(GetPoolsToBeRemovedFunction getPoolsToBeRemovedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeRemovedFunction, List<string>>(getPoolsToBeRemovedFunction, blockParameter);
        }

        
        public Task<List<string>> GetPoolsToBeRemovedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeRemovedFunction, List<string>>(null, blockParameter);
        }

        public Task<string> IncrementStakingEpochRequestAsync(IncrementStakingEpochFunction incrementStakingEpochFunction)
        {
             return ContractHandler.SendRequestAsync(incrementStakingEpochFunction);
        }

        public Task<string> IncrementStakingEpochRequestAsync()
        {
             return ContractHandler.SendRequestAsync<IncrementStakingEpochFunction>();
        }

        public Task<TransactionReceipt> IncrementStakingEpochRequestAndWaitForReceiptAsync(IncrementStakingEpochFunction incrementStakingEpochFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(incrementStakingEpochFunction, cancellationToken);
        }

        public Task<TransactionReceipt> IncrementStakingEpochRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<IncrementStakingEpochFunction>(null, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string validatorSetContract, List<string> initialStakingAddresses, BigInteger delegatorMinStake, BigInteger candidateMinStake, BigInteger stakingFixedEpochDuration, BigInteger stakingTransitionTimeframeLength, BigInteger stakingWithdrawDisallowPeriod, List<byte[]> publicKeys, List<byte[]> internetAddresses)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ValidatorSetContract = validatorSetContract;
                initializeFunction.InitialStakingAddresses = initialStakingAddresses;
                initializeFunction.DelegatorMinStake = delegatorMinStake;
                initializeFunction.CandidateMinStake = candidateMinStake;
                initializeFunction.StakingFixedEpochDuration = stakingFixedEpochDuration;
                initializeFunction.StakingTransitionTimeframeLength = stakingTransitionTimeframeLength;
                initializeFunction.StakingWithdrawDisallowPeriod = stakingWithdrawDisallowPeriod;
                initializeFunction.PublicKeys = publicKeys;
                initializeFunction.InternetAddresses = internetAddresses;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string validatorSetContract, List<string> initialStakingAddresses, BigInteger delegatorMinStake, BigInteger candidateMinStake, BigInteger stakingFixedEpochDuration, BigInteger stakingTransitionTimeframeLength, BigInteger stakingWithdrawDisallowPeriod, List<byte[]> publicKeys, List<byte[]> internetAddresses, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ValidatorSetContract = validatorSetContract;
                initializeFunction.InitialStakingAddresses = initialStakingAddresses;
                initializeFunction.DelegatorMinStake = delegatorMinStake;
                initializeFunction.CandidateMinStake = candidateMinStake;
                initializeFunction.StakingFixedEpochDuration = stakingFixedEpochDuration;
                initializeFunction.StakingTransitionTimeframeLength = stakingTransitionTimeframeLength;
                initializeFunction.StakingWithdrawDisallowPeriod = stakingWithdrawDisallowPeriod;
                initializeFunction.PublicKeys = publicKeys;
                initializeFunction.InternetAddresses = internetAddresses;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<bool> IsInitializedQueryAsync(IsInitializedFunction isInitializedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(isInitializedFunction, blockParameter);
        }

        
        public Task<bool> IsInitializedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInitializedFunction, bool>(null, blockParameter);
        }

        public Task<bool> IsPoolActiveQueryAsync(IsPoolActiveFunction isPoolActiveFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPoolActiveFunction, bool>(isPoolActiveFunction, blockParameter);
        }

        
        public Task<bool> IsPoolActiveQueryAsync(string stakingAddress, BlockParameter blockParameter = null)
        {
            var isPoolActiveFunction = new IsPoolActiveFunction();
                isPoolActiveFunction.StakingAddress = stakingAddress;
            
            return ContractHandler.QueryAsync<IsPoolActiveFunction, bool>(isPoolActiveFunction, blockParameter);
        }

        public Task<BigInteger> MaxWithdrawAllowedQueryAsync(MaxWithdrawAllowedFunction maxWithdrawAllowedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxWithdrawAllowedFunction, BigInteger>(maxWithdrawAllowedFunction, blockParameter);
        }

        
        public Task<BigInteger> MaxWithdrawAllowedQueryAsync(string poolStakingAddress, string staker, BlockParameter blockParameter = null)
        {
            var maxWithdrawAllowedFunction = new MaxWithdrawAllowedFunction();
                maxWithdrawAllowedFunction.PoolStakingAddress = poolStakingAddress;
                maxWithdrawAllowedFunction.Staker = staker;
            
            return ContractHandler.QueryAsync<MaxWithdrawAllowedFunction, BigInteger>(maxWithdrawAllowedFunction, blockParameter);
        }

        public Task<BigInteger> MaxWithdrawOrderAllowedQueryAsync(MaxWithdrawOrderAllowedFunction maxWithdrawOrderAllowedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxWithdrawOrderAllowedFunction, BigInteger>(maxWithdrawOrderAllowedFunction, blockParameter);
        }

        
        public Task<BigInteger> MaxWithdrawOrderAllowedQueryAsync(string poolStakingAddress, string staker, BlockParameter blockParameter = null)
        {
            var maxWithdrawOrderAllowedFunction = new MaxWithdrawOrderAllowedFunction();
                maxWithdrawOrderAllowedFunction.PoolStakingAddress = poolStakingAddress;
                maxWithdrawOrderAllowedFunction.Staker = staker;
            
            return ContractHandler.QueryAsync<MaxWithdrawOrderAllowedFunction, BigInteger>(maxWithdrawOrderAllowedFunction, blockParameter);
        }

        public Task<string> MoveStakeRequestAsync(MoveStakeFunction moveStakeFunction)
        {
             return ContractHandler.SendRequestAsync(moveStakeFunction);
        }

        public Task<TransactionReceipt> MoveStakeRequestAndWaitForReceiptAsync(MoveStakeFunction moveStakeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(moveStakeFunction, cancellationToken);
        }

        public Task<string> MoveStakeRequestAsync(string fromPoolStakingAddress, string toPoolStakingAddress, BigInteger amount)
        {
            var moveStakeFunction = new MoveStakeFunction();
                moveStakeFunction.FromPoolStakingAddress = fromPoolStakingAddress;
                moveStakeFunction.ToPoolStakingAddress = toPoolStakingAddress;
                moveStakeFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(moveStakeFunction);
        }

        public Task<TransactionReceipt> MoveStakeRequestAndWaitForReceiptAsync(string fromPoolStakingAddress, string toPoolStakingAddress, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var moveStakeFunction = new MoveStakeFunction();
                moveStakeFunction.FromPoolStakingAddress = fromPoolStakingAddress;
                moveStakeFunction.ToPoolStakingAddress = toPoolStakingAddress;
                moveStakeFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(moveStakeFunction, cancellationToken);
        }

        public Task<string> OrderWithdrawRequestAsync(OrderWithdrawFunction orderWithdrawFunction)
        {
             return ContractHandler.SendRequestAsync(orderWithdrawFunction);
        }

        public Task<TransactionReceipt> OrderWithdrawRequestAndWaitForReceiptAsync(OrderWithdrawFunction orderWithdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(orderWithdrawFunction, cancellationToken);
        }

        public Task<string> OrderWithdrawRequestAsync(string poolStakingAddress, BigInteger amount)
        {
            var orderWithdrawFunction = new OrderWithdrawFunction();
                orderWithdrawFunction.PoolStakingAddress = poolStakingAddress;
                orderWithdrawFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(orderWithdrawFunction);
        }

        public Task<TransactionReceipt> OrderWithdrawRequestAndWaitForReceiptAsync(string poolStakingAddress, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var orderWithdrawFunction = new OrderWithdrawFunction();
                orderWithdrawFunction.PoolStakingAddress = poolStakingAddress;
                orderWithdrawFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(orderWithdrawFunction, cancellationToken);
        }

        public Task<BigInteger> OrderWithdrawEpochQueryAsync(OrderWithdrawEpochFunction orderWithdrawEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OrderWithdrawEpochFunction, BigInteger>(orderWithdrawEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> OrderWithdrawEpochQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var orderWithdrawEpochFunction = new OrderWithdrawEpochFunction();
                orderWithdrawEpochFunction.ReturnValue1 = returnValue1;
                orderWithdrawEpochFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<OrderWithdrawEpochFunction, BigInteger>(orderWithdrawEpochFunction, blockParameter);
        }

        public Task<BigInteger> OrderedWithdrawAmountQueryAsync(OrderedWithdrawAmountFunction orderedWithdrawAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OrderedWithdrawAmountFunction, BigInteger>(orderedWithdrawAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> OrderedWithdrawAmountQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var orderedWithdrawAmountFunction = new OrderedWithdrawAmountFunction();
                orderedWithdrawAmountFunction.ReturnValue1 = returnValue1;
                orderedWithdrawAmountFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<OrderedWithdrawAmountFunction, BigInteger>(orderedWithdrawAmountFunction, blockParameter);
        }

        public Task<BigInteger> OrderedWithdrawAmountTotalQueryAsync(OrderedWithdrawAmountTotalFunction orderedWithdrawAmountTotalFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OrderedWithdrawAmountTotalFunction, BigInteger>(orderedWithdrawAmountTotalFunction, blockParameter);
        }

        
        public Task<BigInteger> OrderedWithdrawAmountTotalQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var orderedWithdrawAmountTotalFunction = new OrderedWithdrawAmountTotalFunction();
                orderedWithdrawAmountTotalFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<OrderedWithdrawAmountTotalFunction, BigInteger>(orderedWithdrawAmountTotalFunction, blockParameter);
        }

        public Task<BigInteger> PoolDelegatorInactiveIndexQueryAsync(PoolDelegatorInactiveIndexFunction poolDelegatorInactiveIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolDelegatorInactiveIndexFunction, BigInteger>(poolDelegatorInactiveIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> PoolDelegatorInactiveIndexQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var poolDelegatorInactiveIndexFunction = new PoolDelegatorInactiveIndexFunction();
                poolDelegatorInactiveIndexFunction.ReturnValue1 = returnValue1;
                poolDelegatorInactiveIndexFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<PoolDelegatorInactiveIndexFunction, BigInteger>(poolDelegatorInactiveIndexFunction, blockParameter);
        }

        public Task<BigInteger> PoolDelegatorIndexQueryAsync(PoolDelegatorIndexFunction poolDelegatorIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolDelegatorIndexFunction, BigInteger>(poolDelegatorIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> PoolDelegatorIndexQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var poolDelegatorIndexFunction = new PoolDelegatorIndexFunction();
                poolDelegatorIndexFunction.ReturnValue1 = returnValue1;
                poolDelegatorIndexFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<PoolDelegatorIndexFunction, BigInteger>(poolDelegatorIndexFunction, blockParameter);
        }

        public Task<List<string>> PoolDelegatorsQueryAsync(PoolDelegatorsFunction poolDelegatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolDelegatorsFunction, List<string>>(poolDelegatorsFunction, blockParameter);
        }

        
        public Task<List<string>> PoolDelegatorsQueryAsync(string poolStakingAddress, BlockParameter blockParameter = null)
        {
            var poolDelegatorsFunction = new PoolDelegatorsFunction();
                poolDelegatorsFunction.PoolStakingAddress = poolStakingAddress;
            
            return ContractHandler.QueryAsync<PoolDelegatorsFunction, List<string>>(poolDelegatorsFunction, blockParameter);
        }

        public Task<List<string>> PoolDelegatorsInactiveQueryAsync(PoolDelegatorsInactiveFunction poolDelegatorsInactiveFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolDelegatorsInactiveFunction, List<string>>(poolDelegatorsInactiveFunction, blockParameter);
        }

        
        public Task<List<string>> PoolDelegatorsInactiveQueryAsync(string poolStakingAddress, BlockParameter blockParameter = null)
        {
            var poolDelegatorsInactiveFunction = new PoolDelegatorsInactiveFunction();
                poolDelegatorsInactiveFunction.PoolStakingAddress = poolStakingAddress;
            
            return ContractHandler.QueryAsync<PoolDelegatorsInactiveFunction, List<string>>(poolDelegatorsInactiveFunction, blockParameter);
        }

        public Task<BigInteger> PoolInactiveIndexQueryAsync(PoolInactiveIndexFunction poolInactiveIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolInactiveIndexFunction, BigInteger>(poolInactiveIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> PoolInactiveIndexQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var poolInactiveIndexFunction = new PoolInactiveIndexFunction();
                poolInactiveIndexFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolInactiveIndexFunction, BigInteger>(poolInactiveIndexFunction, blockParameter);
        }

        public Task<BigInteger> PoolIndexQueryAsync(PoolIndexFunction poolIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolIndexFunction, BigInteger>(poolIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> PoolIndexQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var poolIndexFunction = new PoolIndexFunction();
                poolIndexFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolIndexFunction, BigInteger>(poolIndexFunction, blockParameter);
        }

        public Task<PoolInfoOutputDTO> PoolInfoQueryAsync(PoolInfoFunction poolInfoFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<PoolInfoFunction, PoolInfoOutputDTO>(poolInfoFunction, blockParameter);
        }

        public Task<PoolInfoOutputDTO> PoolInfoQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var poolInfoFunction = new PoolInfoFunction();
                poolInfoFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<PoolInfoFunction, PoolInfoOutputDTO>(poolInfoFunction, blockParameter);
        }

        public Task<BigInteger> PoolToBeElectedIndexQueryAsync(PoolToBeElectedIndexFunction poolToBeElectedIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolToBeElectedIndexFunction, BigInteger>(poolToBeElectedIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> PoolToBeElectedIndexQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var poolToBeElectedIndexFunction = new PoolToBeElectedIndexFunction();
                poolToBeElectedIndexFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolToBeElectedIndexFunction, BigInteger>(poolToBeElectedIndexFunction, blockParameter);
        }

        public Task<BigInteger> PoolToBeRemovedIndexQueryAsync(PoolToBeRemovedIndexFunction poolToBeRemovedIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolToBeRemovedIndexFunction, BigInteger>(poolToBeRemovedIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> PoolToBeRemovedIndexQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var poolToBeRemovedIndexFunction = new PoolToBeRemovedIndexFunction();
                poolToBeRemovedIndexFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolToBeRemovedIndexFunction, BigInteger>(poolToBeRemovedIndexFunction, blockParameter);
        }

        public Task<string> RemoveMyPoolRequestAsync(RemoveMyPoolFunction removeMyPoolFunction)
        {
             return ContractHandler.SendRequestAsync(removeMyPoolFunction);
        }

        public Task<string> RemoveMyPoolRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RemoveMyPoolFunction>();
        }

        public Task<TransactionReceipt> RemoveMyPoolRequestAndWaitForReceiptAsync(RemoveMyPoolFunction removeMyPoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeMyPoolFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RemoveMyPoolRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RemoveMyPoolFunction>(null, cancellationToken);
        }

        public Task<string> RemovePoolRequestAsync(RemovePoolFunction removePoolFunction)
        {
             return ContractHandler.SendRequestAsync(removePoolFunction);
        }

        public Task<TransactionReceipt> RemovePoolRequestAndWaitForReceiptAsync(RemovePoolFunction removePoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removePoolFunction, cancellationToken);
        }

        public Task<string> RemovePoolRequestAsync(string stakingAddress)
        {
            var removePoolFunction = new RemovePoolFunction();
                removePoolFunction.StakingAddress = stakingAddress;
            
             return ContractHandler.SendRequestAsync(removePoolFunction);
        }

        public Task<TransactionReceipt> RemovePoolRequestAndWaitForReceiptAsync(string stakingAddress, CancellationTokenSource cancellationToken = null)
        {
            var removePoolFunction = new RemovePoolFunction();
                removePoolFunction.StakingAddress = stakingAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removePoolFunction, cancellationToken);
        }

        public Task<string> RemovePoolsRequestAsync(RemovePoolsFunction removePoolsFunction)
        {
             return ContractHandler.SendRequestAsync(removePoolsFunction);
        }

        public Task<string> RemovePoolsRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RemovePoolsFunction>();
        }

        public Task<TransactionReceipt> RemovePoolsRequestAndWaitForReceiptAsync(RemovePoolsFunction removePoolsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removePoolsFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RemovePoolsRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RemovePoolsFunction>(null, cancellationToken);
        }

        public Task<bool> RewardWasTakenQueryAsync(RewardWasTakenFunction rewardWasTakenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RewardWasTakenFunction, bool>(rewardWasTakenFunction, blockParameter);
        }

        
        public Task<bool> RewardWasTakenQueryAsync(string returnValue1, string returnValue2, BigInteger returnValue3, BlockParameter blockParameter = null)
        {
            var rewardWasTakenFunction = new RewardWasTakenFunction();
                rewardWasTakenFunction.ReturnValue1 = returnValue1;
                rewardWasTakenFunction.ReturnValue2 = returnValue2;
                rewardWasTakenFunction.ReturnValue3 = returnValue3;
            
            return ContractHandler.QueryAsync<RewardWasTakenFunction, bool>(rewardWasTakenFunction, blockParameter);
        }

        public Task<string> SetCandidateMinStakeRequestAsync(SetCandidateMinStakeFunction setCandidateMinStakeFunction)
        {
             return ContractHandler.SendRequestAsync(setCandidateMinStakeFunction);
        }

        public Task<TransactionReceipt> SetCandidateMinStakeRequestAndWaitForReceiptAsync(SetCandidateMinStakeFunction setCandidateMinStakeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setCandidateMinStakeFunction, cancellationToken);
        }

        public Task<string> SetCandidateMinStakeRequestAsync(BigInteger minStake)
        {
            var setCandidateMinStakeFunction = new SetCandidateMinStakeFunction();
                setCandidateMinStakeFunction.MinStake = minStake;
            
             return ContractHandler.SendRequestAsync(setCandidateMinStakeFunction);
        }

        public Task<TransactionReceipt> SetCandidateMinStakeRequestAndWaitForReceiptAsync(BigInteger minStake, CancellationTokenSource cancellationToken = null)
        {
            var setCandidateMinStakeFunction = new SetCandidateMinStakeFunction();
                setCandidateMinStakeFunction.MinStake = minStake;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setCandidateMinStakeFunction, cancellationToken);
        }

        public Task<string> SetDelegatorMinStakeRequestAsync(SetDelegatorMinStakeFunction setDelegatorMinStakeFunction)
        {
             return ContractHandler.SendRequestAsync(setDelegatorMinStakeFunction);
        }

        public Task<TransactionReceipt> SetDelegatorMinStakeRequestAndWaitForReceiptAsync(SetDelegatorMinStakeFunction setDelegatorMinStakeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDelegatorMinStakeFunction, cancellationToken);
        }

        public Task<string> SetDelegatorMinStakeRequestAsync(BigInteger minStake)
        {
            var setDelegatorMinStakeFunction = new SetDelegatorMinStakeFunction();
                setDelegatorMinStakeFunction.MinStake = minStake;
            
             return ContractHandler.SendRequestAsync(setDelegatorMinStakeFunction);
        }

        public Task<TransactionReceipt> SetDelegatorMinStakeRequestAndWaitForReceiptAsync(BigInteger minStake, CancellationTokenSource cancellationToken = null)
        {
            var setDelegatorMinStakeFunction = new SetDelegatorMinStakeFunction();
                setDelegatorMinStakeFunction.MinStake = minStake;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDelegatorMinStakeFunction, cancellationToken);
        }

        public Task<string> SetPoolInfoRequestAsync(SetPoolInfoFunction setPoolInfoFunction)
        {
             return ContractHandler.SendRequestAsync(setPoolInfoFunction);
        }

        public Task<TransactionReceipt> SetPoolInfoRequestAndWaitForReceiptAsync(SetPoolInfoFunction setPoolInfoFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPoolInfoFunction, cancellationToken);
        }

        public Task<string> SetPoolInfoRequestAsync(byte[] publicKey, byte[] ip)
        {
            var setPoolInfoFunction = new SetPoolInfoFunction();
                setPoolInfoFunction.PublicKey = publicKey;
                setPoolInfoFunction.Ip = ip;
            
             return ContractHandler.SendRequestAsync(setPoolInfoFunction);
        }

        public Task<TransactionReceipt> SetPoolInfoRequestAndWaitForReceiptAsync(byte[] publicKey, byte[] ip, CancellationTokenSource cancellationToken = null)
        {
            var setPoolInfoFunction = new SetPoolInfoFunction();
                setPoolInfoFunction.PublicKey = publicKey;
                setPoolInfoFunction.Ip = ip;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPoolInfoFunction, cancellationToken);
        }

        public Task<string> SetStakingEpochStartTimeRequestAsync(SetStakingEpochStartTimeFunction setStakingEpochStartTimeFunction)
        {
             return ContractHandler.SendRequestAsync(setStakingEpochStartTimeFunction);
        }

        public Task<TransactionReceipt> SetStakingEpochStartTimeRequestAndWaitForReceiptAsync(SetStakingEpochStartTimeFunction setStakingEpochStartTimeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingEpochStartTimeFunction, cancellationToken);
        }

        public Task<string> SetStakingEpochStartTimeRequestAsync(BigInteger timestamp)
        {
            var setStakingEpochStartTimeFunction = new SetStakingEpochStartTimeFunction();
                setStakingEpochStartTimeFunction.Timestamp = timestamp;
            
             return ContractHandler.SendRequestAsync(setStakingEpochStartTimeFunction);
        }

        public Task<TransactionReceipt> SetStakingEpochStartTimeRequestAndWaitForReceiptAsync(BigInteger timestamp, CancellationTokenSource cancellationToken = null)
        {
            var setStakingEpochStartTimeFunction = new SetStakingEpochStartTimeFunction();
                setStakingEpochStartTimeFunction.Timestamp = timestamp;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingEpochStartTimeFunction, cancellationToken);
        }

        public Task<string> StakeRequestAsync(StakeFunction stakeFunction)
        {
             return ContractHandler.SendRequestAsync(stakeFunction);
        }

        public Task<TransactionReceipt> StakeRequestAndWaitForReceiptAsync(StakeFunction stakeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(stakeFunction, cancellationToken);
        }

        public Task<string> StakeRequestAsync(string toPoolStakingAddress)
        {
            var stakeFunction = new StakeFunction();
                stakeFunction.ToPoolStakingAddress = toPoolStakingAddress;
            
             return ContractHandler.SendRequestAsync(stakeFunction);
        }

        public Task<TransactionReceipt> StakeRequestAndWaitForReceiptAsync(string toPoolStakingAddress, CancellationTokenSource cancellationToken = null)
        {
            var stakeFunction = new StakeFunction();
                stakeFunction.ToPoolStakingAddress = toPoolStakingAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(stakeFunction, cancellationToken);
        }

        public Task<BigInteger> StakeAmountQueryAsync(StakeAmountFunction stakeAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeAmountFunction, BigInteger>(stakeAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeAmountQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var stakeAmountFunction = new StakeAmountFunction();
                stakeAmountFunction.ReturnValue1 = returnValue1;
                stakeAmountFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<StakeAmountFunction, BigInteger>(stakeAmountFunction, blockParameter);
        }

        public Task<BigInteger> StakeAmountByCurrentEpochQueryAsync(StakeAmountByCurrentEpochFunction stakeAmountByCurrentEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeAmountByCurrentEpochFunction, BigInteger>(stakeAmountByCurrentEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeAmountByCurrentEpochQueryAsync(string poolStakingAddress, string staker, BlockParameter blockParameter = null)
        {
            var stakeAmountByCurrentEpochFunction = new StakeAmountByCurrentEpochFunction();
                stakeAmountByCurrentEpochFunction.PoolStakingAddress = poolStakingAddress;
                stakeAmountByCurrentEpochFunction.Staker = staker;
            
            return ContractHandler.QueryAsync<StakeAmountByCurrentEpochFunction, BigInteger>(stakeAmountByCurrentEpochFunction, blockParameter);
        }

        public Task<BigInteger> StakeAmountTotalQueryAsync(StakeAmountTotalFunction stakeAmountTotalFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeAmountTotalFunction, BigInteger>(stakeAmountTotalFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeAmountTotalQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var stakeAmountTotalFunction = new StakeAmountTotalFunction();
                stakeAmountTotalFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<StakeAmountTotalFunction, BigInteger>(stakeAmountTotalFunction, blockParameter);
        }

        public Task<BigInteger> StakeFirstEpochQueryAsync(StakeFirstEpochFunction stakeFirstEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeFirstEpochFunction, BigInteger>(stakeFirstEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeFirstEpochQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var stakeFirstEpochFunction = new StakeFirstEpochFunction();
                stakeFirstEpochFunction.ReturnValue1 = returnValue1;
                stakeFirstEpochFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<StakeFirstEpochFunction, BigInteger>(stakeFirstEpochFunction, blockParameter);
        }

        public Task<BigInteger> StakeLastEpochQueryAsync(StakeLastEpochFunction stakeLastEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeLastEpochFunction, BigInteger>(stakeLastEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeLastEpochQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var stakeLastEpochFunction = new StakeLastEpochFunction();
                stakeLastEpochFunction.ReturnValue1 = returnValue1;
                stakeLastEpochFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<StakeLastEpochFunction, BigInteger>(stakeLastEpochFunction, blockParameter);
        }

        public Task<BigInteger> StakingEpochQueryAsync(StakingEpochFunction stakingEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochFunction, BigInteger>(stakingEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingEpochQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingEpochStartTimeQueryAsync(StakingEpochStartTimeFunction stakingEpochStartTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochStartTimeFunction, BigInteger>(stakingEpochStartTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingEpochStartTimeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochStartTimeFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingFixedEpochDurationQueryAsync(StakingFixedEpochDurationFunction stakingFixedEpochDurationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochDurationFunction, BigInteger>(stakingFixedEpochDurationFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingFixedEpochDurationQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochDurationFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingFixedEpochEndTimeQueryAsync(StakingFixedEpochEndTimeFunction stakingFixedEpochEndTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochEndTimeFunction, BigInteger>(stakingFixedEpochEndTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingFixedEpochEndTimeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochEndTimeFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingTransitionTimeframeLengthQueryAsync(StakingTransitionTimeframeLengthFunction stakingTransitionTimeframeLengthFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingTransitionTimeframeLengthFunction, BigInteger>(stakingTransitionTimeframeLengthFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingTransitionTimeframeLengthQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingTransitionTimeframeLengthFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingWithdrawDisallowPeriodQueryAsync(StakingWithdrawDisallowPeriodFunction stakingWithdrawDisallowPeriodFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingWithdrawDisallowPeriodFunction, BigInteger>(stakingWithdrawDisallowPeriodFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingWithdrawDisallowPeriodQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingWithdrawDisallowPeriodFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StartTimeOfNextPhaseTransitionQueryAsync(StartTimeOfNextPhaseTransitionFunction startTimeOfNextPhaseTransitionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartTimeOfNextPhaseTransitionFunction, BigInteger>(startTimeOfNextPhaseTransitionFunction, blockParameter);
        }

        
        public Task<BigInteger> StartTimeOfNextPhaseTransitionQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartTimeOfNextPhaseTransitionFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> ValidatorSetContractQueryAsync(ValidatorSetContractFunction validatorSetContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(validatorSetContractFunction, blockParameter);
        }

        
        public Task<string> ValidatorSetContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidatorSetContractFunction, string>(null, blockParameter);
        }

        public Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> WithdrawRequestAsync(string fromPoolStakingAddress, BigInteger amount)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.FromPoolStakingAddress = fromPoolStakingAddress;
                withdrawFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(string fromPoolStakingAddress, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.FromPoolStakingAddress = fromPoolStakingAddress;
                withdrawFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> ClaimRewardRequestAsync(ClaimRewardFunction claimRewardFunction)
        {
             return ContractHandler.SendRequestAsync(claimRewardFunction);
        }

        public Task<TransactionReceipt> ClaimRewardRequestAndWaitForReceiptAsync(ClaimRewardFunction claimRewardFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(claimRewardFunction, cancellationToken);
        }

        public Task<string> ClaimRewardRequestAsync(List<BigInteger> stakingEpochs, string poolStakingAddress)
        {
            var claimRewardFunction = new ClaimRewardFunction();
                claimRewardFunction.StakingEpochs = stakingEpochs;
                claimRewardFunction.PoolStakingAddress = poolStakingAddress;
            
             return ContractHandler.SendRequestAsync(claimRewardFunction);
        }

        public Task<TransactionReceipt> ClaimRewardRequestAndWaitForReceiptAsync(List<BigInteger> stakingEpochs, string poolStakingAddress, CancellationTokenSource cancellationToken = null)
        {
            var claimRewardFunction = new ClaimRewardFunction();
                claimRewardFunction.StakingEpochs = stakingEpochs;
                claimRewardFunction.PoolStakingAddress = poolStakingAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(claimRewardFunction, cancellationToken);
        }

        public Task<BigInteger> GetRewardAmountQueryAsync(GetRewardAmountFunction getRewardAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetRewardAmountFunction, BigInteger>(getRewardAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> GetRewardAmountQueryAsync(List<BigInteger> stakingEpochs, string poolStakingAddress, string staker, BlockParameter blockParameter = null)
        {
            var getRewardAmountFunction = new GetRewardAmountFunction();
                getRewardAmountFunction.StakingEpochs = stakingEpochs;
                getRewardAmountFunction.PoolStakingAddress = poolStakingAddress;
                getRewardAmountFunction.Staker = staker;
            
            return ContractHandler.QueryAsync<GetRewardAmountFunction, BigInteger>(getRewardAmountFunction, blockParameter);
        }
    }
}
